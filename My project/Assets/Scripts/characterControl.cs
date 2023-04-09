using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterControl : MonoBehaviour
{
    [SerializeField] GameObject damagePanel;
    [SerializeField] private float moveSpeed;  
    [SerializeField] private static float health=100;
    
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
        moveFunc();
        
    }

    

    private void moveFunc()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        this.gameObject.transform.Translate(hor*moveSpeed*Time.deltaTime,0,ver*moveSpeed*Time.deltaTime);
        if (hor != 0 || ver != 0)
        {
            anim.SetBool("walk", true);
        }
        else anim.SetBool("walk", false);

    }

    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="trap" )
        {
            StartCoroutine(damage());
        }

        
        


    }

    IEnumerator damage()
    {
        damagePanel.SetActive(true);
        yield return new WaitForSeconds(1);
        damagePanel.SetActive(false);

    }








}
