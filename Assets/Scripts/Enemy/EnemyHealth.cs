using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private PlayerStats _stats;

    [SerializeField] private float _enemyMaxHealthPoints;

    [SerializeField] private Animator _finalDoor;

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
        {
            if (GetComponent<Boss>())
            {
                _stats.EnemiesCounter();
                _finalDoor.SetBool("isOpen", true);
            }
            if (GetComponent<Trap>())
                _stats.TrapsCounter();

            Destroy(gameObject);
        }
    }
}
