using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
	/*public bool canBePressed;

	public KeyCode keyToPress;

	public GameObject efectoboton, efectonormal, efectobueno , efectomalo, efectoperfecto;
	void Start()
	{
	}

	void Update()
	{
		if (Input.GetKeyDown(keyToPress))
		{
			if (canBePressed)
			{
				float centro = -6.50f;
				float distancia = Mathf.Abs(transform.position.x - centro);
				Debug.Log("🔍 Distancia de " + gameObject.name + ": " + distancia + " | Posición X: " + transform.position.x);
				if (distancia <= 0.05f)
				{
					Ritmo.instance.NotaPerfecta();
					Instantiate(efectoperfecto, transform.position, efectoperfecto.transform.rotation);
					Instantiate(efectoboton, transform.position, efectoboton.transform.rotation);
				}
				else if (distancia > 0.05f && distancia <= 0.20f)
				{
					Ritmo.instance.NotaBuena();
					Instantiate(efectobueno, transform.position, efectobueno.transform.rotation);
					Instantiate(efectoboton, transform.position, efectoboton.transform.rotation);
				}
				else if (distancia > 0.20f && distancia <=  0.51554f)
				{
					Ritmo.instance.NotaNormal();
					Instantiate(efectonormal, transform.position, efectonormal.transform.rotation);
					Instantiate(efectoboton, transform.position, efectoboton.transform.rotation);
				}
				else 
				{
					Ritmo.instance.NotaMal();
				}
				gameObject.SetActive(false);
			}
		}
	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "Activador")
		{
			canBePressed = true;
		}
	}
	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.tag == "Activador")
		{
			if (gameObject.activeSelf)
			{
				canBePressed = false;
				Ritmo.instance.NotaMal();
				Instantiate(efectomalo, transform.position, efectomalo.transform.rotation);
			}
		}
	}*/
}
