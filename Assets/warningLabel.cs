using UnityEngine;

public class warningLabel : MonoBehaviour
{
    public float timer = 10;
    
    public bool active = true;
    
    public GameObject warninglabel;
    
    
    public GameObject mainMenu;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        mainMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
           
           
       timer -= Time.deltaTime;
                

            
       if (timer <= 0f)
       {
          warninglabel.SetActive(false);
          mainMenu.SetActive(true);
               
       }
        
    }
    
}
