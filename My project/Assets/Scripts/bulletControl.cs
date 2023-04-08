using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletControl : MonoBehaviour
{
    [SerializeField] private static int health;
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
            health -= 10;
            Debug.Log(health);
            Destroy(gameObject);
        }
    }
}
