using UnityEngine;
using System.Collections.Generic;

public class FlechaFactory : MonoBehaviour
{

    public GameObject prefab;
    public Transform spawnPoint;
    public float repeatRate = 1f;
    public List<Sprite> spriteList;
    public GameObject spritePrefab;

    void Start()
    {
        InvokeRepeating("SpawnObject", 0f, repeatRate);
    }

    public void SpawnObject()
    {
        if (prefab != null)
        {
            GameObject flecha = Instantiate(prefab, spawnPoint.position, Quaternion.identity);
            FlechaMovement flechaMovement = flecha.GetComponent<FlechaMovement>();

            if (flechaMovement != null)
            {
                flechaMovement.Instantiate(10f, GetRandomSprite(), GetRandomRotation(), spritePrefab);
            }
        }
    }
    private int GetRandomRotation()
    {
        int[] angles = { 0, 90, 180, 270 };
        return angles[Random.Range(0, angles.Length)];
    }
    private Sprite GetRandomSprite()
    {
        if (spriteList == null || spriteList.Count == 0)
        {
            Debug.LogError("La lista de sprites está vacía o no asignada.");
            return null;
        }

        int index = Random.Range(0, spriteList.Count); // Selecciona un índice aleatorio
        return spriteList[index];
    }
}
