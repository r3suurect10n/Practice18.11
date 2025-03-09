using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private Text _hpUI;
    [SerializeField] private Text _coinsCountUI;

    private Health _health;
    private CoinCollector _coinCollector;

    private void Awake()
    {
        _health = GetComponent<Health>();
        _coinCollector = GetComponent<CoinCollector>();

        _hpUI.text = _health.CurrrentHealth.ToString();
        _coinsCountUI.text = _coinCollector.CoinsCount.ToString();
    }

    public void UpdateHealth (float currentHealth)
    {
        _hpUI.text = currentHealth.ToString();        
    }

    public void UpdateCoinCounter(float currentCoins)
    {        
        _coinsCountUI.text = currentCoins.ToString();
    }
}
