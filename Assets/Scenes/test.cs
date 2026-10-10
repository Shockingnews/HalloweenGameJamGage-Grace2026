using UnityEngine;


public class test : MonoBehaviour
{

    public GameObject screenOne;
    public GameObject screenTwo;
    public GameObject screenThree;
    private bool isActive = true;
    public void Interact()
    {
        if (isActive == true)
        {
            screenOne.SetActive(false);
            isActive = false;
        }
        else if (isActive == false)
        {
            screenOne.SetActive(true);
            isActive = true;
        }


    }
    public void ScreenActive()
    {
        if (isActive == true)
        {
            screenTwo.SetActive(false);
            isActive = false;
        }
        else if (isActive == false)
        {
            screenTwo.SetActive(true);
            isActive = true;
        }


    }
    public void ScreenThreeActive()
    {
        if (isActive == true)
        {
            screenThree.SetActive(false);
            isActive = false;
        }
        else if (isActive == false)
        {
            screenThree.SetActive(true);
            isActive = true;
        }


    }
}
