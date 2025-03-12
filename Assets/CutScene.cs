using Unity.Cinemachine;
using UnityEngine;
using UnityEditor.UIElements;
using System.Collections;
using UnityEngine.UIElements;

public class CutScene : MonoBehaviour
{
    [Header("Objects parameters")]
    [SerializeField] private CinemachineCamera _cutSceneCam;
    [SerializeField] private Camera _mainCam;
    [SerializeField] private GameObject _cutScenePanel;
    [SerializeField] private GameObject _player;

    [Header("Cut scene settings")]
    [SerializeField] private float _cutSceneTime;

    private void Start()
    {
        _player.GetComponent<PlayerInput>().enabled = false;
        StartCoroutine(CutSceneTimer());
    }

    private IEnumerator CutSceneTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(_cutSceneTime);

            _cutSceneCam.Priority.Value = 9;

            yield return new WaitForSeconds(_mainCam.GetComponent<CinemachineBrain>().DefaultBlend.Time);

            _cutScenePanel.SetActive(false);
            _player.GetComponent<PlayerInput>().enabled = true;
        }
    }
}
