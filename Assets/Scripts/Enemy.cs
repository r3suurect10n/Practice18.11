using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _damagePlayer;
    [SerializeField] private float _damageInterval;

    private Coroutine _damageCoroutine;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>())
            _damageCoroutine = StartCoroutine(DamagePlayer(other.GetComponent<Health>()));        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Player>())
            StopCoroutine(_damageCoroutine);
    }

    IEnumerator DamagePlayer(Health health)
    {
        while (true)
        {
            health.TakeDamage(_damagePlayer);
            yield return new WaitForSeconds(2);
        }
    }
}
