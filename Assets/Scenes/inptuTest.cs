using UnityEngine;
using UnityEngine.InputSystem;

public class inptuTest : MonoBehaviour
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
    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.performed)
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
}
