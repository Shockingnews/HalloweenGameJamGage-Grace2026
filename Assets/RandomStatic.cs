using UnityEngine;
using UnityEngine.UI;

public class RandomStatic : MonoBehaviour
{
    public float timer = 10;
    private int randomTime;
    public float staticTime;
    public bool active = false;
    public GameObject _static;
    private Image staticRenderer;
    private Color staticColor;
    public PauseManager pauseManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        randomTime = Random.Range(25, 60);
        staticTime = randomTime;
        staticRenderer = _static.GetComponent<Image>();
        staticColor = staticRenderer.color;
        staticColor.a = 0f;
        _static.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(staticTime <= 0)
        {
            _static.SetActive(true);
            if (active)
            {
                timer -= Time.deltaTime;
                staticColor.a += Time.deltaTime;
                staticRenderer.color = staticColor;

            }
            if (timer <= 0f)
            {
                staticColor.a = 100f;
                staticRenderer.color = staticColor;
                active = false;
                //DisableControls();
            }
        }
    }
    void DisableControls()
    {
        pauseManager.DisableGame();
    }
    public void EnableControls()
    {
        pauseManager.DisableGame();
        randomTime = Random.Range(25, 60);
        _static.SetActive(false);
    }
}
