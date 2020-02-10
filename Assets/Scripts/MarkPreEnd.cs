using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkPreEnd : MonoBehaviour
{
    float speed = 5f;
    Animator myAnimator;
    private Rigidbody2D myRB;
    float velX;
    private PreEndSceneM PESM;
    public GameObject OPESM;
    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
        myRB = GetComponent<Rigidbody2D>();
        PESM = OPESM.GetComponent<PreEndSceneM>();
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
        if (other.gameObject.tag == "Flower")
        {
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "Gate")
        {
            PESM.ShowPreEnd2();
        }
        if(other.gameObject.tag == "Grave")
        {
            PESM.ShowPreEnd3();
        }
    }
}
