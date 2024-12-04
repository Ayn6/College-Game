using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exit");
    }

    public void LoadMenu()
    {
        Debug.Log("2");
        SceneManager.LoadScene("MainMenu");
    }
}
