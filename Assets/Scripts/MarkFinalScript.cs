using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkFinalScript : MonoBehaviour
{
    float speed = 5f;
    Animator myAnimator;
    private Rigidbody2D myRB;
    float velX;
    private FinalScript FS;
    public GameObject FSO;
    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
        myRB = GetComponent<Rigidbody2D>();
        FS = FSO.GetComponent<FinalScript>();
    }

    // Update is called once per frame
    void Update()
    {
        velX = Input.GetAxisRaw("Horizontal");
        myRB.velocity = new Vector2(velX * speed, 0);
        myAnimator.SetFloat("Speed", Mathf.Abs(myRB.velocity.x));
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Door")
        {
            FS.ShowEnd3();
        }

        if(other.gameObject.tag == "Stool")
        {
            FS.ShowEnd5();
        }
    }
}
