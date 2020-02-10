using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MarkMove2 : MonoBehaviour
{
    float speed = 5f;
    Animator myAnimator;
    private Rigidbody2D myRB;
    float velX;
    private SceneManage2 POSM2;
    public GameObject oPOSM2;
    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
        myRB = GetComponent<Rigidbody2D>();
        POSM2 = oPOSM2.GetComponent<SceneManage2>();
    }

    // Update is called once per frame
    void Update()
    {
        velX = Input.GetAxisRaw("Horizontal");
        myRB.velocity = new Vector2(velX * speed, 0);
        myAnimator.SetFloat("Speed", Mathf.Abs(myRB.velocity.x));
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Note")
        {
            POSM2.ShowPart3();
        }

        if(other.gameObject.tag == "FB")
        {
            SceneManager.LoadScene("CoffeeShop", LoadSceneMode.Single);
        }
    }
}
