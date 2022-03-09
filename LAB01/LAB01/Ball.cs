using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D ball;
    float Startingspeed = 100.0f;
    float Increase_ballspeed = 1.15f;
    float Increase_paddlespeed = 1.0f;

    void Start()
    {
        ball = GetComponent<Rigidbody2D>();
        ball.AddForce(new Vector2(1.0f, -1.0f) * Startingspeed);
    }

    void OnCollisionEnter2D(Collision2D Collision)
    {
        if (Collision.collider.CompareTag("Paddle"))
        {
            ball.velocity = ball.velocity * Increase_ballspeed;
            IncreasePaddleSpeed();
        }
    }

    void IncreasePaddleSpeed()
    {
        foreach (var obj in GameObject.FindGameObjectsWithTag("Paddle"))
        {
            var paddle = obj.GetComponent<Paddle>();
            paddle.Speed += Increase_paddlespeed;
        }
    }
}
