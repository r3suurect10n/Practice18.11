using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    [Header("Settings")]    
    [SerializeField] private LayerMask _groundLayer;
    [SerializeField] private Transform _groundCheck;
    [SerializeField] private float _checkRadius;

    [SerializeField] private bool _isGrounded;

    public bool IsGrounded => _isGrounded;
        
    private void Update()
    {
        _isGrounded = Physics.CheckSphere(_groundCheck.position, _checkRadius, _groundLayer);
    }      

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(_groundCheck.position, _checkRadius);
    }
}
