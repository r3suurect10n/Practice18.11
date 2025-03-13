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
            _statsText.text = $"\n������� �����:\t\t{_stats.CoinsCollected}\n\n�������� �����:\t\t{_stats.DamageTaken}\n\n���������� �������:\t\t{_stats.TrapsDestructed}\n\n���������� ������:\t\t{_stats.EnemiesDefeated}";
            _victoryScreen.SetActive(true);
        }

    }
}
