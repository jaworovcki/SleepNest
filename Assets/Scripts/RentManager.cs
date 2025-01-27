using TMPro;
using UnityEngine;

public class RentManager : MonoBehaviour
{
    [SerializeField] private GameObject twoBedroomsPanel;
    [SerializeField] private GameObject oneBedroomPanel;

    [SerializeField] private TextMeshProUGUI noBedroomsText;

    private const string key = "RoomBookingStatus";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int bookingStatus = PlayerPrefs.GetInt(key, 0);

        if (bookingStatus == 1)
        {
            noBedroomsText.text = null;
            twoBedroomsPanel.SetActive(true);
            oneBedroomPanel.SetActive(false);
        }
        else if (bookingStatus == 2)
        {
            noBedroomsText.text = null;
            twoBedroomsPanel.SetActive(false);
            oneBedroomPanel.SetActive(true);
        }
        else
        {
            noBedroomsText.text = "No rooms booked";
            twoBedroomsPanel.SetActive(false);
            oneBedroomPanel.SetActive(false);
        }
        
    }
}
