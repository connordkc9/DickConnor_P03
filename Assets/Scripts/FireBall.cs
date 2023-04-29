using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    private PlayerMovement _player;
    [SerializeField] private ParticleSystem _fireFX;

    private void Awake()
    {
        _player = FindObjectOfType<PlayerMovement>();
        Instantiate(_fireFX, _player.transform);
        
    }

    private void OnDestroy()
    {
        _fireFX.Stop();
    }
}
