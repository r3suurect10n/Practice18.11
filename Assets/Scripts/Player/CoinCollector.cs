using System;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    [SerializeField] PlayerUI _playerUI;

    private int _coinsAmount;
    public int CoinsCount { get; private set; }

    private void Start()
    {
        CoinsCount = 0;
        Debug.Log(CoinsAmount());
    }

    private void OnTriggerEnter(Collider other)
    {        

        if (other.GetComponent<Coin>())
        {
            CoinsCount++;
            _playerUI.UpdateCoinCounter(CoinsCount);            
        }
    }

    private int CoinsAmount()
    {
        return _coinsAmount = GetComponents<Coin>().Length;
    }
}
