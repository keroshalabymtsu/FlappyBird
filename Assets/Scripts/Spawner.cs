using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float spaenRate = 1f;
    public float minHight = -1f;
    public float maxhight = 1f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spaenRate, spaenRate);
    }
    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }
    private void Spawn()
    {
        GameObject pipes = Instantiate(prefab, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minHight, maxhight);
    }
}
