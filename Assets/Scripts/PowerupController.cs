using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PowerupController : MonoBehaviour
{
    public Powerup[] _powerups;
    private Powerup _selected;
    private GameObject _activePowerup;

    private string _name;
    private string _description;
    private Sprite _sprite;
    private GameObject _object;
    private float _duration;
    private float _timeLeft;
    
    [SerializeField] private TextMeshProUGUI _UIName;
    [SerializeField] private TextMeshProUGUI _UIDescription;
    [SerializeField] private Image _UISprite;
    [SerializeField] private Slider _UISlider;
    [SerializeField] private GameObject _UIPanel;

    private void Update()
    {
        #region Testing Hotkeys
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _selected = _powerups[0];
            _name = _selected._name;
            _description = _selected._description;
            _sprite = _selected._sprite;
            _object = _selected._object;
            _duration = _selected._duration;

            ActivatePowerup();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _selected = _powerups[1];
            _name = _selected._name;
            _description = _selected._description;
            _sprite = _selected._sprite;
            _object = _selected._object;
            _duration = _selected._duration;

            ActivatePowerup();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _selected = _powerups[2];
            _name = _selected._name;
            _description = _selected._description;
            _sprite = _selected._sprite;
            _object = _selected._object;
            _duration = _selected._duration;

            ActivatePowerup();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            _selected = _powerups[3];
            _name = _selected._name;
            _description = _selected._description;
            _sprite = _selected._sprite;
            _object = _selected._object;
            _duration = _selected._duration;

            ActivatePowerup();
        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            _UIPanel.SetActive(false);
        }
        #endregion

        //Decrease Timer. If 0, Deactivate.
        if (_timeLeft > 0)
        {
            _timeLeft -= Time.deltaTime;
            _UISlider.value = _timeLeft;
        }
        if (_timeLeft <= 0)
        {
            DeactivatePowerup();
        }
    }

    void ActivatePowerup()
    {
        DeactivatePowerup();
        UIUpdate();
        _activePowerup = Instantiate(_object);
    }
    
    void DeactivatePowerup()
    {
        _UIPanel.SetActive(false);
        Destroy(_activePowerup);
    }

        void UIUpdate()
    {
        _UIName.text = _name;
        _UIDescription.text = _description;
        _UISprite.sprite = _sprite;
        _UISlider.maxValue = _duration;
        _timeLeft = _duration;
        _UIPanel.SetActive(true);
    }

}
