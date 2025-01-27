using System;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsManager : MonoBehaviour
{
    [SerializeField] private Sprite onButton;
    [SerializeField] private Sprite offButton;
    [SerializeField] private Button privacyPolicyButton;
    [SerializeField] private Button contactUsButton;

    [SerializeField] private Button notificationButton;
    [SerializeField] private Button vibrationButton;

    [SerializeField] private Button toggleNotificationButton;
    [SerializeField] private Button toggleVibrationButton;

    public GameObject privacyPolicyPanel;
    public Button backprivacyButton;

    public GameObject contactPanel;
    public Button backcontactButton;
    
    void Start()
    {
        Debug.Log("Start");
        privacyPolicyButton.onClick.AddListener(() => ShowPrivacyPolicyPanel());
        backprivacyButton.onClick.AddListener(() => HidePrivacyPolicyPanel());
        contactUsButton.onClick.AddListener(() => ShowContactPanel());
        backcontactButton.onClick.AddListener(() => HideContactPanel());

        notificationButton.onClick.AddListener(() => ChangeButtonState(toggleNotificationButton));
        vibrationButton.onClick.AddListener(() => ChangeButtonState(toggleVibrationButton));

        toggleNotificationButton.onClick.AddListener(() => ChangeButtonState(toggleNotificationButton));
        toggleVibrationButton.onClick.AddListener(() => ChangeButtonState(toggleVibrationButton));
    }

    public void ShowPrivacyPolicyPanel()
    {
        privacyPolicyPanel.SetActive(true);
    }

    public void HidePrivacyPolicyPanel()
    {
        privacyPolicyPanel.SetActive(false);
    }

    public void ShowContactPanel()
    {
        contactPanel.SetActive(true);
    }

    public void HideContactPanel()
    {
        contactPanel.SetActive(false);
    }

    public void ChangeButtonState(Button button)
    {
        Debug.Log("Button clicked");
        if (button.image.sprite == onButton)
        {
            button.image.sprite = offButton;
        }
        else
        {
            button.image.sprite = onButton;
        }
    }
}
   