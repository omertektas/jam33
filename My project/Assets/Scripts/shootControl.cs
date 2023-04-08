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

    void Start()
    {
        cam =Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var bullet = Instantiate(bulletPrefab, namlu.position, namlu.rotation);
            bullet.GetComponent<Rigidbody>().velocity = namlu.forward * bulletSpeed;
            shootFunction();
        }
       
    }
    private void shootFunction()
    {
        
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));//ekran�n ortas�

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, enemy))
            {
                Debug.Log("Ate� edildi");
           

        }

      
    }
}
