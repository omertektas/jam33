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
    [SerializeField] private GameObject finalVideo;
    
    AudioSource finalSource;
    void Start()
    {
        finalSource = GetComponent<AudioSource>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy1.IsDestroyed() && enemy2.IsDestroyed() && enemy3.IsDestroyed())
        {
            finalSource.enabled = true;
            Invoke("videoFinal",10);
        }
    }

    private void videoFinal()
    {
        finalVideo.SetActive(true);
        Invoke("quitGame", 8);

    }

    private void quitGame() 
    { 
        Application.Quit();
    }
}
