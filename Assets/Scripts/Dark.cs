using UnityEngine;

public class Dark : MonoBehaviour
{
    public GameObject pauseMenuUI;
    private void OnTriggerEnter2D() 
    {
        pauseMenuUI.SetActive(false); 
    }

    
    private void OnTriggerExit2D() 
    {
        pauseMenuUI.SetActive(true); 
    }
}
