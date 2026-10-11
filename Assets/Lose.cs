using UnityEngine;

public class Lose : MonoBehaviour
{
    public GameObject jumpScare;
    public GameObject loseScreen;
    private float timer;
    private bool active = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        jumpScare.SetActive(false);
        loseScreen.SetActive(false);
        timer = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0f)
        {

        }
    }
    public void JumpScare()
    {
        Debug.Log("made it");
        active = true;
        jumpScare.SetActive(true);
    }
    void LoseScreen()
    {
        jumpScare.SetActive(false);
        loseScreen.SetActive(true);
    }
}
