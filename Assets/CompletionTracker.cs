using UnityEngine;

public class CompletionTracker : MonoBehaviour
{
    private int completionWins = 2;
    static public int wins;
    static public int loses;
    public Lose loss;
    public GameObject WinObject;
    public GameObject pcUi;
    public GameObject dialogue;

    public void CheckWins() 
    {
        if(wins == completionWins)
        {
            // activate win ui and end the game
            endGame();
        }
        else
        {
            Debug.Log("not Done");
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        WinObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(loses >= 5)
        {

            Debug.Log("hityo");
            loss.JumpScare();
        }
    }

    void endGame()
    {
        pcUi.SetActive(false);
        WinObject.SetActive(true);
        dialogue.SetActive(false);
    }
}
