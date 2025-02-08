using UnityEngine;

public class FlechaMovement : MonoBehaviour
{

    public float speed = 5f;

    public Sprite defaultSprite;

    private SpriteRenderer childSpriteRenderer;

    void Start()
    {
        Transform hijo = transform.Find("Sprite");
        if (hijo != null)
        {
            childSpriteRenderer = hijo.GetComponent<SpriteRenderer>();
        }

        if (childSpriteRenderer != null)
        {
            childSpriteRenderer.color = Color.red;
        }
        instantiate(speed, defaultSprite, 90);
    }
    void Update()
    {

        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    public void instantiate(float speed, Sprite newSprite, float rot)
    {
        this.speed = speed;
        transform.rotation = Quaternion.Euler(0, 0, rot);
        childSpriteRenderer.sprite = newSprite;
    }
}
