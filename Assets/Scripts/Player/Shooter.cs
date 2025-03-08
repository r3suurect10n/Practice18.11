using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] PlayerMovement _playerMovement;
    [SerializeField] private Bullet _bullet;
    [SerializeField] private float _firePower;
    [SerializeField] private Transform _gun;

    private void Awake()
    {
        _playerMovement = GetComponent<PlayerMovement>();
    }
    public void Shoot()
    {
        Bullet currentBullet = Instantiate(_bullet, _gun.position, Quaternion.identity);
        currentBullet.Initialize(_firePower, -_playerMovement.Direction);
    }
}
