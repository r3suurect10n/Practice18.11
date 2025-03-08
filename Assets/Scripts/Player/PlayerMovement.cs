using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement variables")]
    [SerializeField] private float _jumpPower;
    [SerializeField] private float _movementSpeed;    

    [Header("Settings")]
    [SerializeField] private GroundChecker _groundChecker;
    [SerializeField] private Rigidbody _rb;    
    [SerializeField] private AnimationCurve _curve;    

    public float Direction {  get; private set; }

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _groundChecker = GetComponent<GroundChecker>();
        Direction = 1;
    }     

    public void Move(float direction, bool isJump)
    {
       if (isJump)
        Jump();
        
        if (Mathf.Abs(direction) > 0.01f)
        {
            HorizontalMovement(direction);
            Rotation(direction);
        }
    }

    private void Jump()
    {
        if (_groundChecker.IsGrounded) 
            _rb.linearVelocity = new Vector2(_rb.linearVelocity.x, _jumpPower);
    }

    private void HorizontalMovement(float direction)
    {
        _rb.linearVelocity = new Vector2(-_curve.Evaluate(direction), _rb.linearVelocity.y);
    } 
    
    private void Rotation(float direction)
    {
        Direction = Mathf.Sign(direction);        

        if (Direction > 0)
        {
            _rb.rotation = Quaternion.Euler(0, 0, 0);            

        }
        else if (Direction < 0)
        {
            _rb.rotation = Quaternion.Euler(0, 180, 0);             
        }
    }
}
