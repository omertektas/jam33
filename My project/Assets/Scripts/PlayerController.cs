using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }
        }
        Debug.Log("�mer ba�ard�n");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
