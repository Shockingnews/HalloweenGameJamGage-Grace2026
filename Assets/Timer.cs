using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] TextMeshProUGUI outSideTimerText;

    public Dialogue dialogue;
    public DialogueManager manager;


    public Lose loseManager;
    public bool isActive = false;
    public float timer;
    private int randomTime;
    public float dialogueTime;
    public bool startDialogue = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = 180f;
        randomTime = Random.Range(25, 60);
        dialogueTime = randomTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            dialogueTime -= Time.deltaTime;
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                // jump scare and end game
                StopTime();
                loseManager.JumpScare();
            }
            if(dialogueTime <= 0)
            {
                StopTime();
            }
            
        }
        if (startDialogue)
        {
            if (manager.inText == true)
            {

                Debug.Log("true");
                manager.DisplayNextSentence();
                


            }
            else { manager.StartDialogue(dialogue); }

            StartTime();

        }
        
        if(manager.timer <= 1)
        {
            manager.inText = false;
        }
        
        if (manager.inText == false)
        {
            startDialogue = false;
            //StartTime();
        }

        UpdateTimerText();
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
    public void PuaseTime()
    {
        isActive = false;
    }

    void StartDialogue()
    {
        
        startDialogue = true;
        randomTime = Random.Range(15, 60);
        dialogueTime = randomTime;
    }
    public void UpdateTimerText()
    {
        float minutes = Mathf.FloorToInt(timer / 60);
        float seconds = Mathf.FloorToInt(timer % 60);
        timerText.text = $"{minutes}:{seconds}";
        outSideTimerText.text = $"{minutes}:{seconds}";


    }


}
