using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private float _enemyMaxHealthPoints;
    private float _currentEnemyHealth;

    private void Awake()
    {
        _currentEnemyHealth = _enemyMaxHealthPoints;
    }

    public void EnemyTakeDamage(float damage)
    {
        _currentEnemyHealth -= damage;
        CheckIsAlive();
    }

    private void CheckIsAlive()
    {
        if (_currentEnemyHealth <= 0)
            Destroy(gameObject);
    }
}
