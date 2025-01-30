using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    NavMeshAgent navMeshAgent;
    [SerializeField] private GameObject player;
    [SerializeField] private float onDetectDistance = 10f;
    
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        
    }

    
    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);
        if (distance <= onDetectDistance)
        {
            navMeshAgent.SetDestination(player.transform.position);
        }
        
        
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, onDetectDistance);
    }
}
