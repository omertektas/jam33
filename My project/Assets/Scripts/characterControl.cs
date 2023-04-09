using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class characterControl : MonoBehaviour
{
    [SerializeField] GameObject damagePanel;
    [SerializeField] Transform lock123;
    [SerializeField] private float moveSpeed;  
    [SerializeField] private static float health=100;
    [SerializeField] private static byte temp=0;
    [SerializeField] private bool isLocked=false;
    [SerializeField] private AudioSource aSource;
    [SerializeField] private AudioClip wrong;
    [SerializeField] private AudioClip succes;


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

        if (Vector3.Distance(this.transform.position,lock123.position)<=10)
        {
            if (isLocked==true)
            {
                Debug.Log("çalýþtý");
                StartCoroutine(trueSound());
            }
            else 
            {
                aSource.clip = wrong;
                aSource.Play(); 
            }
        }
        
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

    
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag=="trap" )
        {
            StartCoroutine(damage());
        }
        if (collision.gameObject.tag=="key")
        {
            temp++;
            if (temp==2)
            {
                isLocked = true;
                Debug.Log("kilit açýldý");
            }
            Destroy(collision.gameObject);
        }

        


        
        


    }

    IEnumerator damage()
    {
        damagePanel.SetActive(true);
        yield return new WaitForSeconds(1);
        damagePanel.SetActive(false);

    }

    IEnumerator trueSound()
    {
        aSource.clip = succes;
        aSource.Play(); 
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(2);
    
    }

   








}
