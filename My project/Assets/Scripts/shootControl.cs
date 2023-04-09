using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class shootControl : MonoBehaviour
{
    
    public Camera cam;
    public LayerMask enemy;
    public Transform namlu;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    Vector3 bulletPosition;
    
    void Start()
    {
        cam =Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
       
       
        if (Input.GetMouseButtonDown(0))
        {
            
           
            shootFunction();
           
           
            
        }
       
    }
    private void shootFunction()
    {
        
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));//ekranýn ortasý
        

        RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                
                var bullet = Instantiate(bulletPrefab, namlu.position, namlu.rotation);
                bullet.GetComponent<Rigidbody>().velocity = -(namlu.position-hit.point).normalized * bulletSpeed;
                 

            }

            else
            {
            var bullet = Instantiate(bulletPrefab, namlu.position, namlu.rotation);
            bullet.GetComponent<Rigidbody>().velocity = ray.direction * bulletSpeed;
            }

        
        
        
    }


    

   
}
