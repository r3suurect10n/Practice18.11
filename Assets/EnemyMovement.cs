using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float _enemySpeed;
    [SerializeField] private Rigidbody _enemyRb;
    private void Awake()
    {
        _enemyRb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        _enemyRb.AddForce(Vector3.left * _enemySpeed * Time.deltaTime, ForceMode.Force);
    }
}
