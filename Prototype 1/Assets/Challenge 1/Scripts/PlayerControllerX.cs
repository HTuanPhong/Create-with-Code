using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 25;
    public float rotationSpeed = 70;
    public bool revertInput = false;
    public InputAction MoveAction;

    private Vector2 moveInput;

    // Start is called before the first frame update
    void Start()
    {
        MoveAction.Enable();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        int revert = 1;
        if (revertInput)
        {
            revert = -1;
        }
        // get the user's vertical input
        moveInput = MoveAction.ReadValue<Vector2>();

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * moveInput.y * revert);
    }
}
