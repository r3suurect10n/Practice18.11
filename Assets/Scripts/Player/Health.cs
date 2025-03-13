using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private PlayerUI _playerUI;

    [SerializeField] private GameObject _defeatScreen;
    [SerializeField] private GameObject _playerHPUI;

    [SerializeField] private float _maxHealthPoints;     
    
    public float MaxHealthPoints { get; private set; }
    public float CurrrentHealth { get; private set; }

    private void Awake()
    {
        MaxHealthPoints = _maxHealthPoints;
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
        {
            _playerUI.HideUI();
            _defeatScreen.SetActive(true);
            Destroy(gameObject);                       
        }
    }    
}
