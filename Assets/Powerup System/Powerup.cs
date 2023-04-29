using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Powerup", menuName = "Powerup")]
public class Powerup : ScriptableObject
{
    public string _name;
    public string _description;

    public Sprite _sprite;

    public GameObject _object;

    public float _duration;
}
