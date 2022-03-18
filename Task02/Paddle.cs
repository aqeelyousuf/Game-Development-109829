using UnityEngine;

public class Paddle : MonoBehaviour
{
    public KeyCode Keyup { get; set; }
    public KeyCode Keydown { get; set; }
    public float Paddlespeed { get; set; } = 5.0f;
    public Rigidbody2D Paddlemovement { get; set; }

    public void UpdatePaddleMovement()
    {
        float position = 0.0f;

        if (Input.GetKey(Keyup))
            position = Paddlespeed;
        else if (Input.GetKey(Keydown))
            position = -Paddlespeed;

        Paddlemovement.velocity = new Vector2(Paddlemovement.velocity.x, position);
    }
}
