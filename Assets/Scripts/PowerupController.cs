using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PowerupController : MonoBehaviour
{
    public Powerup[] _powerups;
    private Powerup _selected;

    private string _name;
    private string _description;
    private Sprite _sprite;
    private GameObject _object;
    private float _duration;
    
    [SerializeField] private TextMeshProUGUI _UIName;
    [SerializeField] private TextMeshProUGUI _UIDescription;
    [SerializeField] private Image _UISprite;
    [SerializeField] private Slider _UISlider;
    [SerializeField] private GameObject _UIPanel;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _selected = _powerups[0];
            _name = _selected._name;
            _description = _selected._description;
            _sprite = _selected._sprite;
            _object = _selected._object;
            _duration = _selected._duration;

            UIUpdate();
            _UIPanel.SetActive(true);
        }
    }

    void UIUpdate()
    {
        _UIName.text = _name;
        _UIDescription.text = _description;
        _UISprite.sprite = _sprite;

    }
}
