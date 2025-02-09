using UnityEngine;



public class ArrowMovementScript : MonoBehaviour
{

	[SerializeField] private ArrowPropertiesScript arrowProperties;

	public void Update()
    {
        transform.position += arrowProperties.moveDirection * arrowProperties.speed * Time.deltaTime;
    }
}