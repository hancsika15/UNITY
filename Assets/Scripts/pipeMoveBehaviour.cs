using UnityEngine;

public class pipeMoveBehaviour : MonoBehaviour
{
    [SerializeField]
    private float _speed = .65f;

    private void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;
    }
}
