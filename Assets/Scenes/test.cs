using UnityEngine;


public class test : MonoBehaviour
{

    public GameObject screen;
    private bool isActive = true;
    public void Interact()
    {
        if (isActive == true)
        {
            screen.SetActive(false);
            isActive = false;
        }
        else if (isActive == false)
        {
            screen.SetActive(true);
            isActive = true;
        }


    }
}
