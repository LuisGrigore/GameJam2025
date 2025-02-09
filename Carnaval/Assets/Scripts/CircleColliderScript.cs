using UnityEngine;

public class CircleColliderScript :MonoBehaviour
{
	[SerializeField] private GameObject gameManager;
	private GameObject currentArrow = null;
	private void Update()
    {
		if(currentArrow && Input.GetKeyDown(currentArrow.GetComponent<ArrowPropertiesScript>().keyCode))
		{
			addPoints(getDistance(currentArrow.transform.position.x));
			currentArrow.GetComponent<ArrowCollisionScript>().destroyWithParticles();
			currentArrow = null;
		}
    }

	private void addPoints(float distance)
	{
		if(distance <= 3)
		{
			gameManager.GetComponent<GameManagerPlayerStatsScript>().addGoodCount();
		}
	}
	private void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.CompareTag("Arrow"))
        {
			currentArrow = collider.gameObject;
        }
	}

	private float getDistance(float x)
	{
		return Mathf.Abs(gameObject.transform.position.x - x);
	}
}