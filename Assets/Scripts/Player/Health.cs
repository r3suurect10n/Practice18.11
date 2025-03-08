using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private PlayerUI _playerUI;
    [SerializeField] private float _maxHealthPoints;
    private float _currentHealth;   
    
    private void Awake()
    {
        _currentHealth = _maxHealthPoints;        
    }  

    public void TakeDamage(float damage)
    {
        _currentHealth -= damage;
        _playerUI.UpdateUI(_currentHealth);
        CheckIsAlive();
    }    

    private void CheckIsAlive()
    {
        if (_currentHealth <= 0)
            Destroy(gameObject);
    }    
}
