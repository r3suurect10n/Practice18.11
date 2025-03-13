using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private GameObject _hpPanel;
    [SerializeField] private GameObject _coinsPanel;

    [SerializeField] private Text _hpUI;
    [SerializeField] private Text _coinsCountUI;

    private Health _health;
    private CoinCollector _coinCollector;

    private void Awake()
    {
        _health = GetComponent<Health>();
        _coinCollector = GetComponent<CoinCollector>();
    }

    private void Start()
    {
        _hpUI.text = _health.CurrrentHealth.ToString();
        _coinsCountUI.text = $"{_coinCollector.CoinsCount} / {_coinCollector.CoinsAmount}";
    }

    public void UpdateHealth (float currentHealth)
    {
        _hpUI.text = currentHealth.ToString();        
    }

    public void UpdateCoinCounter(float currentCoins)
    {
        _coinsCountUI.text = $"{currentCoins} / {_coinCollector.CoinsAmount}";
    }

    public void HideUI()
    {
        _hpPanel.SetActive(false);
        _coinsPanel.SetActive(false);
    }
}
