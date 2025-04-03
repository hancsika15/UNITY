using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class flyBehaviour : MonoBehaviour
{
    [SerializeField]
    private float _velocity = 1.5f;

    [SerializeField]
    private float _rotationSpeed = 10f;

    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            _rigidbody.linearVelocity = Vector2.up * _velocity;
        }
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0,0,_rigidbody.linearVelocityY * _rotationSpeed);
    }
}