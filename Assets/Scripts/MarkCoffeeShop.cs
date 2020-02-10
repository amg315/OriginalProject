using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkCoffeeShop : MonoBehaviour
{
    float speed = 5f;
    Animator myAnimator;
    private Rigidbody2D myRB;
    float velX;
    private CoffeeSceneManage CSM;
    public GameObject CSMGO;
    private bool facingRight;
    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
        myRB = GetComponent<Rigidbody2D>();
        CSM = CSMGO.GetComponent<CoffeeSceneManage>();
        facingRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        velX = Input.GetAxisRaw("Horizontal");
        myRB.velocity = new Vector2(velX * speed, 0);
        myAnimator.SetFloat("Speed", Mathf.Abs(myRB.velocity.x));
        ChangeDirection(velX);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Coffee")
        {
            CSM.ShowPart2();
        }
        if(other.gameObject.tag == "Counter")
        {
            CSM.ShowPart3();
        }
        if(other.gameObject.tag == "Table")
        {
            CSM.ShowPart10();
        }
    }

    void ChangeDirection(float horizontal)
    {
        if((horizontal > 0 && !facingRight) || (horizontal < 0 && facingRight))
        {
            Vector3 scalingM = transform.localScale;
            scalingM.x *= -1;
            transform.localScale = scalingM;
            facingRight = !facingRight;
        }
    }
}
