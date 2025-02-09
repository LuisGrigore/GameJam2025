using System;
using System.Collections.Generic;
using UnityEngine;

public class ArrowFatoryScript : MonoBehaviour
{
	[SerializeField] private GameObject arrowPrefab;
	[SerializeField] private float speed = 0;
	[SerializeField] private List<Sprite> sprites;

	public void instantiateArrow()
	{
		GameObject arrow = Instantiate(arrowPrefab, transform.position, transform.rotation);
		arrow.GetComponent<ArrowPropertiesScript>().init(speed, getRandomEnumValue(), getRandomSprite());
	}

	private ArrowDirections getRandomEnumValue()
    {
        Array values = Enum.GetValues(typeof(ArrowDirections));
        return (ArrowDirections)values.GetValue(UnityEngine.Random.Range(0, values.Length));
    }

	private Sprite getRandomSprite()
    {
        int i = UnityEngine.Random.Range(0, sprites.Count);
        return sprites[i];
    }
}