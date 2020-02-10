using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkFallMove : MonoBehaviour
{
    float speed = 5f;
    Animator myAnimator;
    private Rigidbody2D myRB;
    float velX;
    private FallSceneManage FSM;
    public GameObject FSMO;
    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
        myRB = GetComponent<Rigidbody2D>();
        FSM = FSMO.GetComponent<FallSceneManage>();
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
        if(other.gameObject.tag == "Brother")
        {
            FSM.ShowFall2();
        }
    }
}
