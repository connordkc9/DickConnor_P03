using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invincibility : MonoBehaviour
{
    private PlayerMovement _player;


    private void Awake()
    {
        _player = FindObjectOfType<PlayerMovement>();
        _player.Invincibility(1);
    }

    private void OnDestroy()
    {
        _player.Invincibility(0);
    }
}
