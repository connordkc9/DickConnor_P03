using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeUp : MonoBehaviour
{
    private PlayerMovement _player;
    [SerializeField] private Vector3 _scale = new Vector3(1, 1, 1);

    private void Awake()
    {
        _player = FindObjectOfType<PlayerMovement>();
        _player.transform.localScale += _scale;
    }

    private void OnDestroy()
    {
        _player.transform.localScale -= _scale;
    }
}
