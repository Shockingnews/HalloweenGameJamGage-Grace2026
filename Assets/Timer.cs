using UnityEngine;

public class Timer : MonoBehaviour
{
    public Dialogue dialogue;
    public DialogueManager manager;

    public Lose loseManager;
    private bool isActive = false;
    public float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                // jump scare and end game
                StopTime();
                loseManager.JumpScare();
            }
        }
        
    }
    public void StartTime()
    {
        isActive = true;
    }

    void StopTime()
    {
        isActive =false;
        StartDialogue();
    }

    void StartDialogue()
    {
        if (manager.inText == true)
        {

            Debug.Log("true");
            manager.DisplayNextSentence();



        }
        else { manager.StartDialogue(dialogue); }
    }

    
}
