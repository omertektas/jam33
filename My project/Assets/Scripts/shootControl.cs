using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class shootControl : MonoBehaviour
{
    public Camera cam;
    public LayerMask enemy;
    

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
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, enemy))
            {
                Debug.Log("Ateþ edildi");

                
            }
            
        
    }
}
