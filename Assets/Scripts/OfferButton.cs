using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OfferButton : MonoBehaviour
{
    [SerializeField] private Button button;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button.onClick.AddListener(() => SceneManager.LoadScene(1));
    }
}
