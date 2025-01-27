using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RoomManager : MonoBehaviour
{
    [SerializeField] private Button backButton;
    [SerializeField] private Button bookButton;
    [SerializeField] private TextMeshProUGUI buttonText;
    [SerializeField] private Button viewButton;

    [SerializeField] private GameObject errorPanel;
    [SerializeField] private Button closeButton;

    [SerializeField] private int index;

    private const string BookingKey = "RoomBookingStatus";

    public TMP_InputField checkInInputField;
    public TMP_InputField checkOutInputField;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (PlayerPrefs.GetInt(BookingKey, 0) == index)
        {
            checkInInputField.text = "27/12/2024";
            checkOutInputField.text = "01/01/2025";
            buttonText.text = "Cancel Booking";
        }   
        else
        {
            buttonText.text = "Book";
            
            checkInInputField.text = "DD/MM/YYYY";
            checkOutInputField.text = "DD/MM/YYYY";
        }

        backButton.onClick.AddListener(() => SceneManager.LoadScene(0));
        bookButton.onClick.AddListener(BookRoom);

        viewButton.onClick.AddListener(() => SceneManager.LoadScene(3));

        checkInInputField.onEndEdit.AddListener(ValidateDateInputField);
        checkOutInputField.onEndEdit.AddListener(ValidateDateInputField);

        closeButton.onClick.AddListener(() => errorPanel.SetActive(false));
    }

    // Create method when the book button is clicked the text of the button changes to "Cancel booking"
    public void BookRoom()
    {
        if (!AreDatesValid())
        {
            errorPanel.SetActive(true);
            return;
        }

        if (buttonText.text == "Book")
        {
            buttonText.text = "Cancel Booking";
            PlayerPrefs.SetInt(BookingKey, index);
        }
        else
        {
            buttonText.text = "Book";
            PlayerPrefs.DeleteKey(BookingKey);
            checkInInputField.text = "DD/MM/YYYY";
            checkOutInputField.text = "DD/MM/YYYY";
        }
    
    }

    private bool AreDatesValid()
    {
        return ValidateDateInput(checkInInputField.text) && ValidateDateInput(checkOutInputField.text);
    }

    private bool ValidateDateInput(string input)
    {
        return DateTime.TryParseExact(input, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out _);
    }
    

    void ValidateDateInputField(string input)
    {
        if (ValidateDateInput(input))
        {
            Debug.Log("Valid Date: " + input);
        }
        else
        {
            Debug.LogWarning("Invalid Date Format. Use DD/MM/YYYY.");
        }
    }
}
