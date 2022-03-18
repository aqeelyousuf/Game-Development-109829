using UnityEngine;

public class Rightpaddle : Paddle
{
    void Start()
    {
        Keyup = KeyCode.UpArrow;
        Keydown = KeyCode.DownArrow;
        Paddlemovement = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        UpdatePaddleMovement();
    }
}
