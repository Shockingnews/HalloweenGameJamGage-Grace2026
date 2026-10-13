using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class CardScript : MonoBehaviour
{
     
    [SerializeField] private Image cardIcon;
    public Sprite hiddenIconSprite;
    public Sprite IconSprite;

    public bool isSelected;

    public CardController controller;

    private float timer = 0.1f;
    private bool isActive = false;

    public void OnCardClick()
    {
        controller.SetSelected(this);
    }

    public void SetIconSprite(Sprite sprite)
    {
        IconSprite = sprite;
    }

    public void Show()
    {
        cardIcon.sprite = IconSprite;
        isSelected = true;
    }
    void StartShow()
    {
        cardIcon.sprite = IconSprite;
    }
    public void stopSHow()
    {
        controller.HideCards(this);
        //cardIcon.sprite = hiddenIconSprite;
    }

    public void Hide()
    {
        cardIcon.sprite = hiddenIconSprite;
        isSelected=false;
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (isActive)
        //{
        //    timer -= time.deltaTime;
        //}
        //if(timer <= 0)
        //{
        //    isActive = false;
        //    Hide():
        //}
    }
}
