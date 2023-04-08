using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class cameraControl : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    [SerializeField] private float sensitivity;
    float mouseX,mouseY;

    private void Start()
    {
        Cursor.lockState= CursorLockMode.Locked;
    }
    private void LateUpdate()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, target.position+offset, Time.deltaTime);
        mouseX += Input.GetAxis("Mouse X") * sensitivity;
        mouseY += Input.GetAxis("Mouse Y") * sensitivity;
        if (mouseY>=50)
        {
            mouseY = 50;
        }
        if (mouseY < -80)
        {
            mouseY = -80;

        }
        this.transform.eulerAngles=new Vector3(-mouseY,mouseX,0); 
        target.transform.eulerAngles= new Vector3(0, mouseX, 0);
    }
}
