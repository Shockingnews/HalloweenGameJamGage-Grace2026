using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagment : MonoBehaviour
{

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Cridits()
    {
        SceneManager.LoadScene(2);
    }
    
}
