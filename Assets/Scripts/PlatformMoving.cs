using System.Collections;
using UnityEngine;

public class PlatformMoving : MonoBehaviour
{
    [SerializeField] private Transform[] _platformPostions;
    [SerializeField] private float _platformSpeed;

    private Transform _currentTarget;
    private Coroutine _idleWaiter;
    [SerializeField] private float _waitTime;

    private void Start()
    {
        if (_platformPostions.Length > 0)
            StartCoroutine(MovePlatform());
    }
    

    private IEnumerator MovePlatform() 
    {


        while (true)
        {
            Transform currentTarget = _platformPostions[0];

            while (Vector3.Distance(transform.position, currentTarget.position) != 0)
            {
                transform.position = Vector3.MoveTowards(transform.position, currentTarget.position, _platformSpeed * Time.deltaTime);
                yield return null;
            }

            yield return new WaitForSeconds(_waitTime);

            _platformPostions[0] = _platformPostions[1];
            _platformPostions[1] = currentTarget;
        }
    }
}
 