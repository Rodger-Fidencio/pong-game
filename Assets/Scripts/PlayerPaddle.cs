using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 _diraction;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            _diraction= Vector2.up;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            _diraction = Vector2.down;
        }
        else
        {
            _diraction = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        if (_diraction.sqrMagnitude != 0)
        {
            _rigidbody.AddForce(_diraction * speed);
        }
        
    }
}
