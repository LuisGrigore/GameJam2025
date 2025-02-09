using UnityEngine;

public class ArrowCollisionScript : MonoBehaviour
{
	public void destroyWithParticles()
	{
		Destroy(gameObject);
	}

	private void OnTriggerExit2D(Collider2D collider)
	{
		if (collider.CompareTag("Circle"))
        {
            destroyWithParticles();
        }
	}
}
