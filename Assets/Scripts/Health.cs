using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private float _maxHealthPoints;
    [SerializeField] private float _currentHealth;

    [SerializeField] Text _healthText;
    [SerializeField] private bool _isPlayer;

    private bool _isAlive;

    private void Awake()
    {
        _currentHealth = _maxHealthPoints;
        _isAlive = true;
    }

    private void Update()
    {
        if (!_isAlive)
            Destroy(gameObject);

        if (_isPlayer)
            _healthText.text = _currentHealth.ToString();
    }

    public void TakeDamage(float damage)
    {
        _currentHealth -= damage;
        CheckIsAlive();
    }

    private void CheckIsAlive()
    {
        if (_currentHealth > 0)
            _isAlive = true;
        else
            _isAlive = false;
    }
}
