using UnityEngine;

public class ArrowCollisionScript : MonoBehaviour
{
	[SerializeField] private GameObject particles;
	public void destroyWithParticles()
	{
		Instantiate(particles, transform.position, transform.rotation);
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
