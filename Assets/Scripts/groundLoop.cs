using UnityEngine;

public class groundLoop : MonoBehaviour
{
    [SerializeField]
    private float _speed = 1.3f;

    [SerializeField]
    private float _width = 6f;

    [SerializeField]
    SpriteRenderer _spriteRenderer;

    private Vector2 _startSize;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _startSize = new(
            x: _spriteRenderer.size.x,
            y: _spriteRenderer.size.y);
    }

    private void Update()
    {
        _spriteRenderer.size = new Vector2(
            x: _spriteRenderer.size.x + _speed * Time.deltaTime,
            y: _spriteRenderer.size.y);


        if ( _spriteRenderer.size.x > _width ) 
        {
            _spriteRenderer.size = _startSize;            
        }
    }
}
