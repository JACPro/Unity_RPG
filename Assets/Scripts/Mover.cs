using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    [SerializeField] private Transform _target;
    private NavMeshAgent _navAgent;
    private Animator _animator;

    private void Awake()
    {
        _navAgent = GetComponent<NavMeshAgent>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            MoveToCursor();
        }

        UpdateAnimator();
    }

    private void UpdateAnimator()
    {
        Vector3 globalVelocity = _navAgent.velocity;
        Vector3 localVelocity = transform.InverseTransformDirection(globalVelocity);
        _animator.SetFloat("ForwardSpeed", localVelocity.magnitude);
    }

    private void MoveToCursor()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            _navAgent.SetDestination(hit.point);
        }
    }
}
