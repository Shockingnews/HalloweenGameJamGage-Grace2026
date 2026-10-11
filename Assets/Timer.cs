using UnityEngine;

public class Timer : MonoBehaviour
{
    public Lose loseManager;
    private bool isActive = false;
    private float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            timer -= Time.deltaTime;
        }
        if(timer <= 0)
        {
            // jump scare and end game
            StopTime();
            loseManager.JumpScare();
        }
    }
    public void StartTime()
    {
        isActive = true;
    }

    void StopTime()
    {
        isActive =false;
    }

    
}
