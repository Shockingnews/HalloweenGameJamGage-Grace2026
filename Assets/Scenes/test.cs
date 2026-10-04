using UnityEngine;


public class test : MonoBehaviour
{

    public GameObject hi;
    private bool ah = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Interact()
    {
        if (ah == true)
        {
            hi.SetActive(false);
            ah = false;
        }
        else if (ah == false)
        {
            hi.SetActive(true);
            ah = true;
        }


    }
}
