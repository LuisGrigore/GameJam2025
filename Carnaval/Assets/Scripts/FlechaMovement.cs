using UnityEngine;

public class FlechaMovement : MonoBehaviour
{

    public float speed = 5f;

    public Sprite defaultSprite;

    private SpriteRenderer childSpriteRenderer;

    void Start()
    {
    }
    void Update()
    {

        transform.position += Vector3.left * speed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Colisi�n con: " + other.gameObject.name);
        Destroy(gameObject); // Destruye este objeto
    }

    public void Instantiate(float speed, Sprite newSprite, float rot, GameObject hijoPrefab)
    {
        GameObject hijo = Instantiate(hijoPrefab, transform.position, Quaternion.identity);
        hijo.transform.SetParent(transform);
        hijo.GetComponent<FlechaSprite>().Instantiate(newSprite);

        this.speed = speed;
        transform.rotation = Quaternion.Euler(0, 0, rot);
    }
}
