using UnityEngine;


public class test : MonoBehaviour
{

    public GameObject screenOne;
    public GameObject screenTwo;
    public GameObject screenThree;
    private bool isActive = true;
    public GameObject PC;
    public GameObject PCScreen;
    public GameObject staticPc;
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
    public void EnterPC()
    {
        if (isActive == true)
        {
            PC.SetActive(false);
            PCScreen.SetActive(true);
            isActive = false;
            //staticPc.SetActive(false);
        }
        else if (isActive == false)
        {
            PC.SetActive(true);
            PCScreen.SetActive(false);
            isActive = true;
        }
    }
}
