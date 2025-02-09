using UnityEngine;

public class CircleColliderScript :MonoBehaviour
{

	private GameObject currentArrow = null;
	private void Update()
    {
		if(currentArrow && Input.GetKeyDown(currentArrow.GetComponent<ArrowPropertiesScript>().keyCode))
		{
			currentArrow.GetComponent<ArrowCollisionScript>().destroyWithParticles();
			currentArrow = null;
		}
    }
	private void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.CompareTag("Arrow"))
        {
			currentArrow = collider.gameObject;
        }
	}

}