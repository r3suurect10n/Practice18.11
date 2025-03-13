using UnityEngine;

public class DoorKey : MonoBehaviour
{
    [SerializeField] private Animator _door;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>())
        {
            _door.SetBool("isOpen", true);
            Destroy(gameObject);
        }
    }
}
