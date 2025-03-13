using UnityEngine;
using UnityEngine.UI;

public class VictoryScene : MonoBehaviour
{
    [SerializeField] private PlayerStats _stats;
    [SerializeField] private Text _statsText;
    [SerializeField] private GameObject _victoryScreen;

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>())
        {
            other.GetComponent<PlayerInput>().enabled = false;
            _stats.CollectStats();
            _statsText.text = $"\nСобрано монет:\t\t{_stats.CoinsCollected}\n\nПолучено урона:\t\t{_stats.DamageTaken}\n\nУничтожено ловушек:\t\t{_stats.TrapsDestructed}\n\nУничтожено врагов:\t\t{_stats.EnemiesDefeated}";
            _victoryScreen.SetActive(true);
        }

    }
}
