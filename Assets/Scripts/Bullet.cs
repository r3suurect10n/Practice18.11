using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody currentBulletVelocity;

    private void Awake()
    {
        currentBulletVelocity = GetComponent<Rigidbody>();
    }

    public void Initialize(float firePower, float direction)
    {
        currentBulletVelocity.linearVelocity = new Vector2(firePower * Mathf.Sign(direction), currentBulletVelocity.linearVelocity.y);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Coin>())
            Debug.Log("Попал в монетку");
    }
}
