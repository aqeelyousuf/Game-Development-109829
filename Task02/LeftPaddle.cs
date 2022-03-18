using UnityEngine;

public class Leftpaddle : Paddle
{
    void Start()
    {
        Keyup = KeyCode.W;
        Keydown = KeyCode.S;
        Paddlemovement = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        UpdatePaddleMovement();
    }
}
