using System;
using UnityEngine;
using UnityEngine.AI;

public class RatScript : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float didectDistance = 10f;
    private NavMeshAgent navMeshAgent;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();

        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);
        if (distance <= didectDistance)
        {
            navMeshAgent.SetDestination(player.position);
        }
        
    }
    // private void OnDrawGizmos()
    // {
    //     Gizmos.color = Color.red;
    //     Gizmos.DrawWireSphere(transform.position, didectDistance);
    // }
}
