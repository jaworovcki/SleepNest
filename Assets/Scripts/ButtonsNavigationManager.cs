using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsNavigationManager : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] private Button roomsButton;
    [SerializeField] private Button rentButton;
    [SerializeField] private Button photoButton;
    [SerializeField] private Button infoButton;
    [SerializeField] private Button settingsButton;

    [Header("Panels")]
    [SerializeField] private GameObject roomsPanel;
    [SerializeField] private GameObject rentPanel;
    [SerializeField] private GameObject photoPanel;
    [SerializeField] private GameObject infoPanel;
    [SerializeField] private GameObject settingsPanel;

    [SerializeField] private GameObject LoadingImage;

    private GameObject currentPanel;

    void Start()
    {
        StartCoroutine(DisplayLoadingImage());
        
        ChangePanel(roomsPanel);

        roomsButton.onClick.AddListener(() => ChangePanel(roomsPanel));
        rentButton.onClick.AddListener(() => ChangePanel(rentPanel));
        photoButton.onClick.AddListener(() => ChangePanel(photoPanel));
        infoButton.onClick.AddListener(() => ChangePanel(infoPanel));
        settingsButton.onClick.AddListener(() => ChangePanel(settingsPanel));
        
    }

    private void ChangePanel(GameObject panel)
    {
        if (currentPanel != null)
        {
            currentPanel.SetActive(false);
        }

        panel.SetActive(true);
        currentPanel = panel;
    }

    private IEnumerator DisplayLoadingImage()
    {
        LoadingImage.SetActive(true);
        yield return new WaitForSeconds(3);
        LoadingImage.SetActive(false);
    }
}
