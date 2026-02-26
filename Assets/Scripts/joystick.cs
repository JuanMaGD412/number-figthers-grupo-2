using UnityEngine;

public class joystick : MonoBehaviour
{
    public float speed = 5f; // Speed of the player movement
    public Joystick joystick2; // Reference to the Joystick component

    private Rigidbody rb;
    private Vector3 movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        GameObject joystickObj = GameObject.FindGameObjectWithTag("Joystick");
        if (joystickObj != null)
            joystick2 = joystickObj.GetComponent<Joystick>();
    }

        // Update is called once per frame
    void Update()
    {
            if (joystick2 == null) return;
            float horizontalInput = joystick2.Horizontal;
            float verticalInput = joystick2.Vertical;

            movement = new Vector3(horizontalInput, 0f, verticalInput);
    }

    void FixedUpdate()
    {
        if (joystick2 == null) return;
        rb.velocity = movement * speed;
    }
}
