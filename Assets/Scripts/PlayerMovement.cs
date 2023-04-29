using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] CharacterController _controller;
    public Material[] _materials;
    [SerializeField] Renderer _renderer;
    
    public float _moveSpeed = 10f;

    private void Start()
    {
        
        _renderer.enabled = true;
        _renderer.sharedMaterial = _materials[0];
    }

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if(direction.magnitude >= 0.1f)
        {
            _controller.Move(direction * _moveSpeed * Time.deltaTime);
        }
    }

    public void Speedup(float amount)
    {
        Debug.Log("Speeding Up!");
        _moveSpeed += amount;
    }

    public void Invincibility(int index)
    {
        _renderer.sharedMaterial = _materials[index];
    }
}
