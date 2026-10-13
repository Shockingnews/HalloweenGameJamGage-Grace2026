using NUnit.Framework;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CardController : MonoBehaviour
{
    [SerializeField] CardScript cardPrefab;
    [SerializeField] Transform gridTransform;
    [SerializeField] Sprite[] sprites;

    public Dialogue dialogue;
    public Dialogue dialoguetwo;
    public DialogueManager manager;

    private float lost;

    private List<Sprite> spritePair;

    private int count;

    public CompletionTracker completion;

    CardScript firstSelected;
    CardScript secondSelected;

    void Start()
    {
        PrepareSprites();
        CreateCards();
    }
    void Update()
    {
        
            if (manager.inText == true)
            {

                Debug.Log("true");
                manager.DisplayNextSentence();



            }
            
        


    }
    private void PrepareSprites()
    {
        spritePair = new List<Sprite>();
        for (int i = 0; i < sprites.Length; i++)
        { 
            spritePair.Add(sprites[i]);
            spritePair.Add(sprites[i]);
        }
        ShuffleSprites(spritePair);
    }

    void CreateCards()
    {
        for (int i = 0; i < spritePair.Count; i++)
        {
            CardScript card = Instantiate(cardPrefab,gridTransform);
            card.SetIconSprite(spritePair[i]);
            card.controller = this;
        } 
    }

    void ShuffleSprites(List<Sprite> spritesList)
    {
        for(int i = spritesList.Count - 1;i > 0; i--)
        {
            int randomIndex = Random.Range(0,i + 1);

            Sprite temp = spritesList[i];
            spritesList[i] = spritesList[randomIndex];
            spritesList[randomIndex] = temp;
        }
    }

    public void SetSelected(CardScript card)
    {
        if(card.isSelected == false)
        {
            card.Show();
            if(firstSelected == null)
            {
                firstSelected = card;
                return;
            }
            if (secondSelected == null)
            {
                secondSelected = card;
                StartCoroutine(CheckMatching(firstSelected, secondSelected));
                
                firstSelected = null;
                secondSelected = null;
                
            }
        }
    }

    IEnumerator CheckMatching(CardScript a, CardScript b)
    {
        yield return new WaitForSeconds(0.5f);
        if(a.IconSprite == b.IconSprite)
        {
            count++;
            if(count == 3)
            {
                Debug.Log("win");
                CompletionTracker.wins += 1;
                completion.CheckWins();
                //Destroy(gameObject);
                if (manager.inText == true)
                {

                    Debug.Log("true");
                    manager.DisplayNextSentence();



                }
                else { manager.StartDialogue(dialogue); }

            }
        }
        else
        {
            a.Hide();
            b.Hide();

            lost += 1;
            if(lost  == 3)
            {
                lost = 0;
                CompletionTracker.loses += 1;
                if (manager.inText == true)
                {

                    Debug.Log("true");
                    manager.DisplayNextSentence();



                }
                else { manager.StartDialogue(dialoguetwo); }
            }
            
        }
    }
}
