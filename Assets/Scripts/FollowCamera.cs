using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private Transform _target;
    
    private void LateUpdate()
    {
        transform.position = _target.position;
    }
}
