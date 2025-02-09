using UnityEngine;
public enum ArrowDirections
{
	UP,
	DOWN,
	LEFT,
	RIGHT
}
public class ArrowPropertiesScript : MonoBehaviour
{
	[SerializeField] public float speed = 0;
	[SerializeField] public ArrowDirections direction = ArrowDirections.LEFT;
	[SerializeField] public SpriteRenderer spriteRenderer;
	[SerializeField] public KeyCode keyCode;
	public Vector3 moveDirection = Vector3.left;


	public void init(float speed, ArrowDirections direction, Sprite sprite)
	{
		this.speed = speed;
		this.direction = direction;
		rotate(direction);
		moveDirection = getMovementVector(direction);
		keyCode = getKeyCode(direction);
		spriteRenderer.sprite = sprite;
	}

	private void rotate(ArrowDirections direction)
	{
		switch(direction)
		{
			case ArrowDirections.LEFT:
				break;
			case ArrowDirections.RIGHT:
				transform.rotation = Quaternion.Euler(0, 0, 180);
				break;
			case ArrowDirections.UP:
				transform.rotation = Quaternion.Euler(0, 0, 90);
				break;
			case ArrowDirections.DOWN:
				transform.rotation = Quaternion.Euler(0, 0, 270);
				break;
		}
	}

	private Vector3 getMovementVector(ArrowDirections direction)
	{
		switch(direction)
		{
			case ArrowDirections.LEFT:
				return Vector3.left;
			case ArrowDirections.RIGHT:
				return -Vector3.right;
			case ArrowDirections.UP:
				return Vector3.left;
			case ArrowDirections.DOWN:
				return -Vector3.right;
			default:
				return Vector3.left;
		}
	}

	private KeyCode getKeyCode(ArrowDirections direction)
	{
		switch(direction)
		{
			case ArrowDirections.LEFT:
				return KeyCode.LeftArrow;
			case ArrowDirections.RIGHT:
				return KeyCode.LeftArrow;
			case ArrowDirections.UP:
				return KeyCode.UpArrow;
			case ArrowDirections.DOWN:
				return KeyCode.DownArrow;
			default:
				return KeyCode.DownArrow;
		}
	}
}