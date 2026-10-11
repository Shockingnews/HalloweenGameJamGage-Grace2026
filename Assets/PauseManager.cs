using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{

    public GameObject PauseUI;
    public GameObject buttonObject;
    public GameObject ball;
    public MazeInput maze;
    public Timer timer;


    private Rigidbody2D rb;
    private Button[] buttons;
    


    void start()
    {
        PauseUI.active = false;
        

    }

    void Awake()
    {
        buttons = buttonObject.GetComponentsInChildren<Button>();
        rb = ball.GetComponent<Rigidbody2D>();

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
        rb.WakeUp();
        PauseUI.active = false;
        maze.enabled = true;


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

                rb.Sleep();
                maze.enabled = false;
                timer.PuaseTime();

            }
            else
            {
                foreach (Button b in buttons)
                {
                    b.enabled = true;
                }
                
                PauseUI.active = false;
                rb.WakeUp();
                maze.enabled = true;
                timer.StartTime();
            }

        }
    }

    public void DisableGame()
    {
        
        foreach (Button b in buttons)
        {
            b.enabled = false;
        }
        rb.Sleep();
        maze.enabled = false;

    }
}
