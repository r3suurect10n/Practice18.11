using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] private float _damage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Damagable"))
            other.gameObject.GetComponent<Health>().TakeDamage(_damage);
        
        if (gameObject.CompareTag("Bullet"))
            Destroy(gameObject);
    }
}
