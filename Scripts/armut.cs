using UnityEngine;

public class armut : MonoBehaviour
{
    SpriteRenderer gorunum;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gorunum = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gorunum.color = new Color(0, 1, 0, 0.5f);
        }
    }
    */
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gorunum.color = new Color(0, 1, 0, 0.5f);
        }
    }
}
