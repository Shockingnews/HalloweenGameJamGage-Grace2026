using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{

    public GameObject PauseUI;
    public GameObject buttons;
    private GameObject buttonsOne;
    private Button _buttonsOne;
    private Button[] test;
    //private GameObject buttonsTwo;
    //private GameObject buttonsThree;


    void start()
    {
        PauseUI.active = false;
        //_buttonsOne = transform.Find("PuzzleOne").gameObject.GetComponent<Button>();
         //= buttonsOne.GetComponent<Button>();

    }

    void Awake()
    {
        test = buttons.GetComponentsInChildren<Button>();
        //_buttonsOne = transform.Find("PuzzleOne").gameObject.GetComponent<Button>();

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

        //_buttonsOne.enabled = true;
        foreach (Button b in test)
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
                foreach(Button b in test)
                {
                    b.enabled = false;
                }
                //_buttonsOne.enabled = false;


            }
            else
            {
                foreach (Button b in test)
                {
                    b.enabled = true;
                }
                //_buttonsOne.enabled = true;
                PauseUI.active = false;

            }

        }
    }

    public void DisableGame()
    {

    }
}
