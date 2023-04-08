using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform player;
    UnityEngine.AI.NavMeshAgent enemy;
    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        GoPlayer();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
        }
    }
    void GoPlayer()
    {
        if (Vector3.Distance(player.position, this.gameObject.transform.position) < 30)
        {
            enemy.SetDestination(player.position);
        }
      
    }
}
