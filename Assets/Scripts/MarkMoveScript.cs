using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MarkMoveScript : MonoBehaviour
{
    float speed = 5f;
    Animator myAnimator;
    private Rigidbody2D myRB;
    float velX;
    private PartOneStateManage POSM;
    public GameObject oPOSM;
    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
        myRB = GetComponent<Rigidbody2D>();
        POSM = oPOSM.GetComponent<PartOneStateManage>();
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
        if(other.gameObject.tag == "door")
        {
            POSM.ShowPart3();
        }

        if(other.gameObject.tag == "Door")
        {
            POSM.ShowPart4();
        }

        if(other.gameObject.tag == "Stool")
        {
            POSM.ShowPart6();
        }
    }
}
