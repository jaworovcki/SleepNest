using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RoomsManager : MonoBehaviour
{
    [SerializeField] private Button button2Bedrooms;
    [SerializeField] private Button button1Bedroom;
    
    void Start()
    {
        // Add listeners to the button button2Bedrooms to redirect to the scene with index 1
        button2Bedrooms.onClick.AddListener(() => SceneManager.LoadScene(1));
        button1Bedroom.onClick.AddListener(() => SceneManager.LoadScene(2));
        
    }
}
