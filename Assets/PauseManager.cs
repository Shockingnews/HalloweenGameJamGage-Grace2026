using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class PauseManager : MonoBehaviour
{
    
    public GameObject PauseUI;

    void start()
    {
        PauseUI.active = false;
    }

    void Awake()
    {
        
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
    public void Quit()
    {
        SceneManager.LoadScene(0);
    }
    public void Resume()
    {
       

       
        
        PauseUI.active = false;
        

    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (PauseUI.active == false)
            {
               
                PauseUI.active = true;
                
                
            }
            else
            {
                
                PauseUI.active = false;

            }

        }
    }

    public void DisableGame()
    {
        
    }
}
