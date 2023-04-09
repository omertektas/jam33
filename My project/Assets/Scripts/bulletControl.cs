using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletControl : MonoBehaviour
{
    [SerializeField] private static  int health=100;
    void Start()
    {
        Destroy(gameObject,2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="enemy")
        {
            health -= 20;
            Debug.Log(health);
            
            if (health <= 0)
            {
                health = 100;//buraya bak
                Destroy(other.gameObject);
            }
        }
    }
}
