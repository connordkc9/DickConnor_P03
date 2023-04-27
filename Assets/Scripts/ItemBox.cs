using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    [SerializeField] private PowerupController _controller;
    public Powerup[] _powerups;
    private Powerup _selected;
    int index;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            index = Random.Range(0, _powerups.Length);
            _selected = _powerups[index];
            Debug.Log(_selected);
        }
    }
}
