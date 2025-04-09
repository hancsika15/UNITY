using System.Threading;
using UnityEngine;

public class PipeSponer : MonoBehaviour
{
    [SerializeField]
    private float _maxTime = 1.5f;

    [SerializeField]
    private float _highRange = 0.5f;

    [SerializeField]
    private GameObject PIPE;

    private float timer;

    private void SpawnPipe()
    {
        Vector3 spawnPos = 
            transform.position + new Vector3(0, Random.Range(-_highRange,+_highRange));
        
        GameObject newPipe = Instantiate(PIPE, spawnPos, Quaternion.identity);

        Destroy(newPipe, 10f);
    }

    private void Start()
    {
        SpawnPipe();
    }

    private void Update()
    {
        if (timer > _maxTime) {
            SpawnPipe();
            timer = 0;
        }
        timer += Time.deltaTime;

    }

}
