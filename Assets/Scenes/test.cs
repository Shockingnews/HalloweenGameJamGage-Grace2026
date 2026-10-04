using UnityEngine;
using UnityEngine.inputSystem;

public class test : MonoBehaviour
{

    public GameObject test;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnInteract()
    {
        test.SetActive(true);
        GameObject.SetActive(false);
    }
}
