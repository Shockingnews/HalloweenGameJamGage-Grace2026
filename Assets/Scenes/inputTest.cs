using UnityEngine;
using UnityEngine.InputSystem;

public class inputTest : MonoBehaviour
{
    public GameObject PcScreen;
    public GameObject PC;
    public GameObject staticPc;
    private bool isActive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            if (isActive == true)
            {
                PcScreen.SetActive(false);
                //staticPc.SetActive(false);
                PC.SetActive(true);
                isActive = false;
            }
            else if (isActive == false)
            {
                PcScreen.SetActive(true);
                isActive = true;
            }
        }
            
    }
}
