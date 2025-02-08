using UnityEngine;
using System.Collections.Generic;

public class FlechaFactory : MonoBehaviour
{

    public GameObject prefab;
    public Transform spawnPoint;
    public float repeatRate = 1f;
    public Sprite sprite;

    void Update()
    {
        InvokeRepeating("SpawnObject", 0f, repeatRate);
    }

    public void SpawnObject()
    {
        if (prefab != null)
        {
            GameObject flecha = Instantiate(prefab, spawnPoint.position, Quaternion.identity);
            FlechaMovement flechaMovement = flecha.GetComponent<FlechaMovement>();
            flechaMovement.instantiate(10, sprite, 90);
        }
    }
}
