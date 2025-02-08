using UnityEngine;

public class Efectos : MonoBehaviour
{
	public float vidautil = 1f;
	void Start()
	{

	}

	void Update()
	{
		Destroy(gameObject, vidautil);
	}
}
