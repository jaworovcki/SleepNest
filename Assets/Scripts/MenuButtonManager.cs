using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MenuButtonManager : MonoBehaviour
{
    [SerializeField] private Sprite defaultSprite;
    [SerializeField] private Sprite selectedSprite;

    [SerializeField] private TextMeshProUGUI text;

    private static MenuButtonManager lastClickedButton;

    private Image buttonImage;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(ChangeSprite);

        buttonImage = GetComponent<Image>(); 
        if (buttonImage != null)
        {
            buttonImage.sprite = defaultSprite;
        }
    }

     private void ChangeSprite()
    {
        if (lastClickedButton != null && lastClickedButton != this)
        {
            lastClickedButton.ResetToDefault();
        }

        if (buttonImage != null)
        {
            buttonImage.sprite = selectedSprite;
        }

        text.color = new Color32(255, 255, 0, 255);
        lastClickedButton = this;
    }

    private void ResetToDefault()
    {
        if (buttonImage != null)
        {
            buttonImage.sprite = defaultSprite;
        }

        text.color = new Color32(255, 255, 255, 255); // Reset text color to default (white)
    }
}
