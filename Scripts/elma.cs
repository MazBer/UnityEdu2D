using UnityEngine;
using UnityEngine.InputSystem;

public class elma : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.linearVelocityX = -2;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.linearVelocityX = 2;
        } else
        {
            rb.linearVelocityX = 0;
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocityY = 5;
        }
    }
}