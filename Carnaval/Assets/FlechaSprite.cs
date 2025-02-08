using UnityEngine;

public class FlechaSprite : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Instantiate(Sprite newSprite)
    {
        SpriteRenderer childSpriteRenderer = GetComponent<SpriteRenderer>();
        childSpriteRenderer.sprite = newSprite;
    }
}
