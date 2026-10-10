using UnityEngine;

public class CompletionTracker : MonoBehaviour
{
    private int completionWins = 3;
    static public int wins;

     public void CheckWins() 
    {
        if(wins == completionWins)
        {
            // activate win ui and end the game
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
