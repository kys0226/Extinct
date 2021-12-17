using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
   
    public float speed = 8f;
    private Rigidbody rd;

    Vector3 move;

    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();

    }


    void Update()
    {

        float movespeed = speed * Time.deltaTime;


        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            transform.Translate(Vector3.left * movespeed);
        }

        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            transform.Translate(Vector3.right * movespeed);
        }

        if (Input.GetButtonDown("Jump") && this.rigid2D.velocity.y == 0)
        {
            this.animator.SetTrigger("JumpTrigger");
             GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 300.0f));
        }

    }


}
