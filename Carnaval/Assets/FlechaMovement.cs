using UnityEngine;

public class FlechaMovement : MonoBehaviour
{

    public float speed = 5f;
    SpriteRenderer childSpriteRenderer;

    void Start()
    {
        childSpriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }
    void Update()
    {

        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    public void instantiate(float speed, Sprite newSprite, float rot)
    {
        this.speed = speed;
        transform.rotation = Quaternion.Euler(0, 0, rot);
        if (childSpriteRenderer != null && newSprite != null)
        {
            childSpriteRenderer.sprite = newSprite;
        }
    }
}
