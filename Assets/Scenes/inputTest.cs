using UnityEngine;
using UnityEngine.InputSystem;

public class inputTest : MonoBehaviour
{
    public GameObject Pc;
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
                Pc.SetActive(false);
                isActive = false;
            }
            else if (isActive == false)
            {
                Pc.SetActive(true);
                isActive = true;
            }
        }
            
    }
}
