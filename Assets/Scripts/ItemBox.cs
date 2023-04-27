using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    private PowerupController _controller;
    public Powerup[] _powerups;
    private Powerup _selected;
    int index;

    [SerializeField] private ParticleSystem _collectParticle;

    private void Awake()
    {
        _controller = FindObjectOfType<PowerupController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Select Random Powerup
            index = Random.Range(0, _powerups.Length);
            _selected = _powerups[index];
            Debug.Log(_selected);

            //Set Powerup Data
            _controller._name = _selected._name;
            _controller._description = _selected._description;
            _controller._sprite = _selected._sprite;
            _controller._object = _selected._object;
            _controller._duration = _selected._duration;

            _controller.ActivatePowerup();

            Instantiate(_collectParticle, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
