using UnityEngine;

public class PlayerColision : MonoBehaviour
{
    public CompletionTracker completion;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision != null)
        {
            Debug.Log("hi");
            CompletionTracker.wins += 1;
            completion.CheckWins();
        }
    }
}
