using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class level2 : MonoBehaviour
{
    [SerializeField] private GameObject enemy1;
    [SerializeField] private GameObject enemy2;
    [SerializeField] private GameObject enemy3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy1.IsDestroyed() && enemy2.IsDestroyed() && enemy3.IsDestroyed())
        {
            //buraya video gelecek
        }
    }
}
