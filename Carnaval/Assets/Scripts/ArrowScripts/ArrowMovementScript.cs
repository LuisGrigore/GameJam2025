using UnityEngine;



public class ArrowMovementScript : MonoBehaviour
{

	[SerializeField] private ArrowPropertiesScript arrowProperties;
	
	public void Start()
	{
		arrowProperties.moveDirection = rotateDirection(arrowProperties.direction);
	}

	public void Update()
    {
        transform.position += arrowProperties.moveDirection * arrowProperties.speed * Time.deltaTime;
    }

	public void init(float speed, ArrowDirections direction, Sprite sprite)
	{
		arrowProperties.speed = speed;
		arrowProperties.direction = direction;
		arrowProperties.moveDirection = rotateDirection(direction);
		arrowProperties.spriteRenderer.sprite = sprite;
	}

	private Vector3 rotateDirection(ArrowDirections direction)
	{
		switch(direction)
		{
			case ArrowDirections.LEFT:
				return Vector3.left;
			case ArrowDirections.RIGHT:
				transform.rotation = Quaternion.Euler(0, 0, 180);
				return -Vector3.right;
			case ArrowDirections.UP:
				transform.rotation = Quaternion.Euler(0, 0, 90);
				return Vector3.left;
			case ArrowDirections.DOWN:
				transform.rotation = Quaternion.Euler(0, 0, 270);
				return -Vector3.right;
		}
		return Vector3.left;
	}

}