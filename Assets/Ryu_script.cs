
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ryu_script : MonoBehaviour
{
    [SerializeField] public float speed = 4f, jumpForce = 200f;
    Rigidbody2D rb;
    Animator anim;
    [SerializeField] bool grounded;
    [SerializeField] float groundRadius = -2.4f;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask Ground_layer;

    void Start ()
    {
        rb=GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update ()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, Ground_layer);
        anim.SetBool("Grounded", grounded);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("coucou");
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        if (anim.GetBool("Grounded"))
        {
            if (anim.GetBool("Crouch")==false)
            {
                Attack();
                Move();
            }
            Crouch();
            
            anim.SetBool("CanWalk", true);
        }
    }
    void Attack() {
        if(Input.GetKeyDown(KeyCode.W) && rb.position.y < -2.3) {
            anim.SetTrigger("Attack");
        }
    }
    void Jump() {
        if (anim.GetBool("Grounded") && anim.GetBool("Crouch")==false)
        {

            rb.AddForce(new Vector2(0, jumpForce));
            anim.SetTrigger("Jump");
            anim.SetBool("CanWalk", false);
        }
    }
    void Move()
    {
        if (anim.GetBool("CanWalk"))
        {
            if (!Input.GetKey(KeyCode.S) || !Input.GetKey(KeyCode.DownArrow))
            {
                float move = Input.GetAxis("Horizontal");
                transform.Translate(Vector2.right * move * speed * Time.deltaTime);
                anim.SetFloat("Speed", Mathf.Abs(move));
            }

        }
    }
    void Crouch()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            anim.SetBool("CanWalk", false);
            anim.SetBool("Crouch", true);
            anim.SetFloat("Speed", 0);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow)) {
            Debug.Log("pakoukou");
            anim.SetBool("Crouch", false);
        }
    }
    }