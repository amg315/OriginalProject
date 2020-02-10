using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MarkMoveEvents : MonoBehaviour
{
    float speed = 5f;
    Animator myAnimator;
    private Rigidbody2D myRB;
    float velX;
    private bool facingRight;
    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
        myRB = GetComponent<Rigidbody2D>();
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
        if(other.gameObject.tag == "Flower")
        {
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "Spring")
        {
            SceneManager.LoadScene("SpringDay", LoadSceneMode.Single);
        }
        if(other.gameObject.tag == "Summer")
        {
            SceneManager.LoadScene("SummerDay", LoadSceneMode.Single);
        }
        if(other.gameObject.tag == "Fall")
        {
            SceneManager.LoadScene("Fall Day", LoadSceneMode.Single);
        }
        if(other.gameObject.tag == "Winter")
        {
            SceneManager.LoadScene("WinterDay", LoadSceneMode.Single);
        }
    }

    void ChangeDirection(float horizontal)
    {
        if ((horizontal > 0 && !facingRight) || (horizontal < 0 && facingRight))
        {
            Vector3 scalingM = transform.localScale;
            scalingM.x *= -1;
            transform.localScale = scalingM;
            facingRight = !facingRight;
        }
    }
}
