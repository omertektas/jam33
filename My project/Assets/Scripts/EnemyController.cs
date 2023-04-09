using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform player;
    UnityEngine.AI.NavMeshAgent enemy;
    
    AudioSource enemyAudioSource;
    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
        enemyAudioSource = GetComponent<AudioSource>();  
        enemyAudioSource.Pause();
        
    }

    // Update is called once per frame
    void Update()
    {
        GoPlayer();
    }
   
    void GoPlayer()
    {
        if (Vector3.Distance(player.position, this.gameObject.transform.position) < 30)
        {
            enemy.SetDestination(player.position);
            enemyAudioSource.UnPause();
        }
       
        else
        {
            enemyAudioSource.Pause();
           
        }

    }
}
