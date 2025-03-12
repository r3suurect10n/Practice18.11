using System;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    [SerializeField] PlayerUI _playerUI;

    public int CoinsAmount { get; private set; }
    public int CoinsCount { get; private set; }    

    private void Start()
    {
        CoinsCount = 0;
        CoinsAmount = CoinsOnScene();
    }

    private void OnTriggerEnter(Collider other)
    {        

        if (other.GetComponent<Coin>())
        {
            CoinsCount++;
            _playerUI.UpdateCoinCounter(CoinsCount);            
        }
    }

    private int CoinsOnScene()
    {
        GameObject[] coins = GameObject.FindGameObjectsWithTag("Collectable");
        return coins.Length;
    }
}
