using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterControl : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpSpeed;
    Rigidbody rb;
    bool isGrounded;
    Animator anim;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        isGrounded = false;
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        jumpFunc();
        moveFunc();
    }

    

    private void moveFunc()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        this.gameObject.transform.Translate(hor*moveSpeed*Time.deltaTime,0,ver*moveSpeed*Time.deltaTime);

    }

    private void jumpFunc()
    {
       

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(transform.up * jumpSpeed);
            isGrounded=false;
        }
       
        
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="ground")
        {
            isGrounded=true;
        }
        


    }

    private void animationController()
    {
        //if (rb.velocity.x>0 || rb.velocity.z>0)
        //{
        //    anim.SetBool("walk", true);
        //}
        //else
        //{
        //    anim.SetBool("walk", false);

        //}
    }






}
