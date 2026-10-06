using UnityEngine;
using UnityEngine.InputSystem;

public class MazeInput : MonoBehaviour
{
    private Vector3 rotation;
    public float speed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotation * Time.deltaTime * speed);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        rotation = new Vector3(0f, 0f, context.ReadValue<Vector2>().x);

    }
}
