using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{

    public GameObject PauseUI;
    public GameObject buttonObject;
    
    private Button[] buttons;
    


    void start()
    {
        PauseUI.active = false;
        

    }

    void Awake()
    {
        buttons = buttonObject.GetComponentsInChildren<Button>();
        

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

        
        foreach (Button b in buttons)
        {
            b.enabled = true;
        }

        PauseUI.active = false;


    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (PauseUI.active == false)
            {

                PauseUI.active = true;
                foreach(Button b in buttons)
                {
                    b.enabled = false;
                }
                


            }
            else
            {
                foreach (Button b in buttons)
                {
                    b.enabled = true;
                }
                
                PauseUI.active = false;

            }

        }
    }

    public void DisableGame()
    {

    }
}
