using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private Text _hpUI;

    private Health _health;

    private void Awake()
    {
        _health = GetComponent<Health>();
    }

    public void UpdateUI(float currentHealth)
    {
        _hpUI.text = currentHealth.ToString();
    }
}
