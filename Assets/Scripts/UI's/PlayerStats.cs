using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private Health _playerHealth;
    [SerializeField] private CoinCollector _coinCollector;

    public float DamageTaken { get; private set; }
    public float CoinsCollected { get; private set; }
    public int TrapsDestructed { get; private set; }
    public int EnemiesDefeated { get; private set; }


    public void CollectStats()
    {
        DamageTaken = _playerHealth.MaxHealthPoints - _playerHealth.CurrrentHealth;
        CoinsCollected = _coinCollector.CoinsCount;
    }

    public void TrapsCounter()
    {
        TrapsDestructed++;
    }

    public void EnemiesCounter()
    {
        EnemiesDefeated++;
    }
}
