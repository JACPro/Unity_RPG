using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    [SerializeField] private Transform _target;
    private NavMeshAgent _navAgent;
    
    private void Awake()
    {
        _navAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        _navAgent.SetDestination(_target.position);
    }
}
