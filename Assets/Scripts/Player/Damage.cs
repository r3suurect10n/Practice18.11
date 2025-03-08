using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] private float _damage;   

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<EnemyHealth>())
        {
            other.GetComponent<EnemyHealth>().EnemyTakeDamage(_damage);            
        }
        if (GetComponent<Bullet>())
            Destroy(gameObject);
    }
}
