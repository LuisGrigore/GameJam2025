using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton : MonoBehaviour
{
	private SpriteRenderer SpriteRenderer;
	public Sprite BotonPresionado;
	public Sprite BotonNoPresionado;

	public KeyCode[] Teclas;
	void Start()
	{
		SpriteRenderer = GetComponent<SpriteRenderer>();
	}

	void Update()
	{
		bool algunaTeclaPresionada = false;

		foreach (KeyCode tecla in Teclas)
		{
			if (Input.GetKey(tecla))
			{
				algunaTeclaPresionada = true;
				break;
			}
		}
		SpriteRenderer.sprite = algunaTeclaPresionada ? BotonPresionado : BotonNoPresionado;
	}
}
