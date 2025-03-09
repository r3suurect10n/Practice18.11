using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private PlayerUI _playerUI;
    [SerializeField] private float _maxHealthPoints;     
    
    public float CurrrentHealth { get; private set; }

    private void Awake()
    {
        CurrrentHealth = _maxHealthPoints;        
    }  

    public void TakeDamage(float damage)
    {
        CurrrentHealth -= damage;
        _playerUI.UpdateHealth(CurrrentHealth);
        CheckIsAlive();
    }    

    private void CheckIsAlive()
    {
        if (CurrrentHealth <= 0)
            Destroy(gameObject);
    }    
}
