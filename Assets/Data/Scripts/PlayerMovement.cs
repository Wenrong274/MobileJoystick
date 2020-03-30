using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Joystick Joystick;
    [SerializeField] private JoystickButton JoystickButton;
    [SerializeField] private Rigidbody Rigidbody;
    [SerializeField] private float Speed = 5;
    [SerializeField] private float JumpHeight = 3;
    private bool jump;

    void Update()
    {
        Rigidbody.velocity = new Vector3((Joystick.Horizontal + Input.GetAxis("Horizontal")) * Speed, Rigidbody.velocity.y, (Joystick.Vertical + Input.GetAxis("Vertical")) * Speed);

        if (!jump && JoystickButton.Pressed || Input.GetButton("Jump"))
        {
            jump = true;
            Rigidbody.velocity += Vector3.up * JumpHeight;
        }

        if (jump && !JoystickButton.Pressed || Input.GetButton("Jump"))
        {
            jump = false;
        }

        if (Mathf.Abs(transform.localPosition.y) >= 50)
        {
            Rigidbody.velocity = Vector3.zero;
            transform.localPosition = Vector3.zero;
        }
    }
}
