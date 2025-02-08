using UnityEngine;

public class FlechaFactory : MonoBehaviour
{

    public GameObject prefab;
    public Transform spawnPoint;

    public void SpawnObject()
    {
        if (prefab != null)
        {
            Instantiate(prefab, spawnPoint.position, Quaternion.identity);
        }
    }
}
