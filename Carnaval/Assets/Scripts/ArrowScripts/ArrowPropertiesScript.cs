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
	public Vector3 moveDirection = Vector3.left;
}