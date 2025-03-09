using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    [SerializeField] PlayerUI _playerUI;
    public int CoinsCount { get; private set; }

    private void Start()
    {
        CoinsCount = 0;
    }

    private void OnTriggerEnter(Collider other)
    {        

        if (other.GetComponent<Coin>())
        {
            CoinsCount++;
            _playerUI.UpdateCoinCounter(CoinsCount);            
        }
    }
}
