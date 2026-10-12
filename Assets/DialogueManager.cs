using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TMP_Text dialogueText;
    public bool inText = false;

    public float timer = 2f;
    private bool activeTimer = false;



    [SerializeField] private GameObject dialogueImg;
    private Queue<string> sentences;

    private void Awake()
    {
        sentences = new Queue<string>();
       
    }

    void Update()
    {
        if (activeTimer)
        {
            timer -= Time.deltaTime;
        }
        if(timer < 0)
        {
            activeTimer = false;
            EndDialogue();
        }
    }

    public void StartDialogue(Dialogue dialogue)
    {
        inText = true;
        dialogueImg.SetActive(true);
        




        Debug.Log("d");

        sentences.Clear();

        int test = 0;

        foreach (string sentence in dialogue.sentences)
        {
            test += 1;
            
            sentences.Enqueue(sentence);
            if (test == 1)
            {
                dialogueText.text = sentence;
            }
        }
        

        DisplayNextSentence();
        

            
            
            
        
        

    }

    public void DisplayNextSentence()
    {
        

            
        
        if (!activeTimer)
        {
            
            
            activeTimer = true;

        }

        

        if (timer <= 0)
        {
            string sentence = sentences.Dequeue();
            dialogueText.text = sentence;
            activeTimer = false;

            timer = 2f;
            if (sentences.Count == 0)
            {

                EndDialogue();
                return;

            }
        }
        
            
        
        


    }
    void EndDialogue()
    {
        activeTimer = false;
            timer = 2f;
            dialogueImg.SetActive(false);
            inText = false;
            Debug.Log("false");
       //activeTimer = true;
        //if (timer <= 0)
        //{

        //    activeTimer = false;
        //    timer = 2f;
        //    dialogueImg.SetActive(false);
        //    inText = false;
        //    Debug.Log("false");
        //}

    }
}
