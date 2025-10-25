using UnityEngine;

public class SmoothMovement : MonoBehaviour
{
    public float maxSpeed = 5f;
    public float acceleration = 10f;
    public float deceleration = 15f;
    
    private Vector2 velocity = Vector2.zero;
    
    private void Update()
    {
        HandleMovement();
    }
    
    private void HandleMovement()
    {
        // Giriş kontrolü
        float horizontal = 0f;
        float vertical = 0f;
        
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            horizontal = 1f;
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            horizontal = -1f;
        }

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            vertical = 1f;
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            vertical = -1f;
        }

        Vector2 inputDirection = new Vector2(horizontal, vertical).normalized;
        
        // Tuşa basılıyorsa - İvmelenme
        if (inputDirection.magnitude > 0)
        {
            // Hızı yavaşça artır
            velocity += inputDirection * acceleration * Time.deltaTime;
            
            // Maksimum hızı aş
            if (velocity.magnitude > maxSpeed)
            {
                velocity = velocity.normalized * maxSpeed;
            }
        }
        // Tuş basılı değilse - Yavaşlama
        else
        {
            // Hızı yavaşça azalt
            if (velocity.magnitude > 0)
            {
                Vector2 decelerationAmount = velocity.normalized * deceleration * Time.deltaTime;
                
                // Hız sıfırın altına düşmesin
                if (decelerationAmount.magnitude > velocity.magnitude)
                {
                    velocity = Vector2.zero;
                }
                else
                {
                    velocity -= decelerationAmount;
                }
            }
        }
        
        // Pozisyonu güncelle
        transform.position += (Vector3)velocity * Time.deltaTime;
    }
}