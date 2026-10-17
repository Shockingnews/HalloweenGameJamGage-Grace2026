using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class CardScript : MonoBehaviour
{
     
    [SerializeField] private Image cardIcon;
    public Sprite hiddenIconSprite;
    public Sprite IconSprite;
    public GameObject screen;

    public bool isSelected;

    public CardController controller;

    private float timer = 3f;
    private bool isActive = true;

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
        Show();
        screen = GameObject.Find("PuzzleTwoScreen");
        

    }

    // Update is called once per frame
    void Update()
    {
        if(screen.active == true)
        {

            if (isActive)
            {
                timer -= Time.deltaTime;
            }

            if (timer <= 0)
            {
                isActive = false;
                Hide();
                timer = 2f;
            }
        }
       

    }
}
