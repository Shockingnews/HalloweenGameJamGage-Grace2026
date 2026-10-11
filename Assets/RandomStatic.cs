using UnityEngine;

public class RandomStatic : MonoBehaviour
{
    public float timer;
    public bool active = false;
    public GameObject _static;
    private Material staticRenderer;
    private Color staticColor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        staticRenderer = _static.GetComponent<Renderer>().material;
        staticColor = staticRenderer.color;
        staticColor.a = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            timer -= Time.deltaTime;
            staticColor.a += Time.deltaTime;


        }
        if (timer <= 0f)
        {
            staticColor.a = 100f;
            active = false;
        }
    }
    void DisableControls()
    {

    }
}
