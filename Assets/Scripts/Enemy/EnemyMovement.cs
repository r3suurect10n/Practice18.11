using System.Collections;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float _enemySpeed;
    [SerializeField] private float _enemyIdleTime;
    [SerializeField] private bool _movingLeft;
    [SerializeField] private bool _isIdle;
    
    [SerializeField] private Rigidbody _enemyRb;    

    private void Awake()
    {
        _enemyRb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (!_isIdle)
            _enemyRb.linearVelocity = new Vector2(_movingLeft ? _enemySpeed : -_enemySpeed, _enemyRb.linearVelocity.y);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Stopper>())
        {
            StartCoroutine(EnemyIdle());
        }
    }

    private IEnumerator EnemyIdle()
    {
        _isIdle = true;
        _enemyRb.linearVelocity = Vector2.zero;
        yield return new WaitForSeconds(_enemyIdleTime);
        _movingLeft = !_movingLeft;
        transform.rotation = Quaternion.Euler(0, _movingLeft ? 180 : 0, 0);
        _isIdle = false;
    }
}
