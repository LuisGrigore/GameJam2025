using UnityEngine;

public enum ArrowDirections
{
	UP,
	DOWN,
	LEFT,
	RIGHT
}

public class ArrowMovementScript : MonoBehaviour
{
	[SerializeField] private float speed = 0;
	[SerializeField] private ArrowDirections direction = ArrowDirections.LEFT;
	[SerializeField] private SpriteRenderer spriteRenderer;
	private Vector3 moveDirection = Vector3.left;

	
	public void Start()
	{
		moveDirection = rotateDirection(direction);
	}

	public void Update()
    {
        transform.position += moveDirection * speed * Time.deltaTime;
    }

	public void init(float speed, ArrowDirections direction, Sprite sprite)
	{
		this.speed = speed;
		this.direction = direction;
		moveDirection = rotateDirection(direction);
		spriteRenderer.sprite = sprite;
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