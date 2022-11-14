
/*
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject prefab;
    public float spawnRate = 1f;
    public float minHeight = -1f;
    public float maxHeight = 1f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        GameObject Obstacle = Instantiate(prefab, transform.position, Quaternion.identity);
        Obstacle.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }

}
*/