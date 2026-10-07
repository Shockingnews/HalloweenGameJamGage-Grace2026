using NUnit.Framework;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CardController : MonoBehaviour
{
    [SerializeField] CardController cardPrefab;
    [SerializeField] Transform gridTransform;
    [SerializeField] Sprite[] sprites;

    private List<Sprite> spritePair;


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
            CardController card = Instantiate(cardPrefab,gridTransform);
            card.SetIconSprite(spritePair[i]);
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
}
