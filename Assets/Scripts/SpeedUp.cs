using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    private PlayerMovement _player;
    [SerializeField] private float _speedIncrease = 5;

    private void Awake()
    {
        _player = FindObjectOfType<PlayerMovement>();
        _player.Speedup(_speedIncrease);
    }

    private void OnDestroy()
    {
        _player.Speedup(-1 * _speedIncrease);
    }
}
