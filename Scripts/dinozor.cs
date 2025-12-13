using UnityEngine;

public class dinozor : MonoBehaviour
{
    private Animator anim;
    private SpriteRenderer sr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        int girdi = (int)Input.GetAxisRaw("Horizontal");
        anim.SetInteger("deger", girdi);

        if(girdi < 0){
            sr.flipX = true;
        }
        else
        {
            sr.flipX = false;
        }
    }
}