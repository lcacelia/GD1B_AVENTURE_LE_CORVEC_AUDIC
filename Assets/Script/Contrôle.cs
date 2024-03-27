using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed = 5f; 
    public Sprite[] sprites; 
    private Rigidbody2D rb; 
    private SpriteRenderer spriteRenderer; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
        rb.gravityScale = 0f; // Désactive la gravité pour éviter le glissement

        spriteRenderer = GetComponent<SpriteRenderer>(); 
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); 
        float verticalInput = Input.GetAxis("Vertical"); 

        Vector2 movement = new Vector2(horizontalInput, verticalInput); 
        if (movement != Vector2.zero) // Vérifie si le joueur se déplace
        {
            Vector2 velocity = movement * speed; // Calcule la vélocité du mouvement
            rb.velocity = velocity; 

            // Change le sprite en fonction de la direction du mouvement
            ChangeSpriteDirection(horizontalInput, verticalInput);
        }
       
    }
    void ChangeSpriteDirection(float horizontalInput, float verticalInput)
    {
        // Change le sprite en fonction de la direction du mouvement
        if (horizontalInput < 0) 
        {
            spriteRenderer.sprite = sprites[0]; 
        }
        else if (horizontalInput > 0) 
        {
            spriteRenderer.sprite = sprites[1]; 
        }
        else if (verticalInput > 0)
        {
            spriteRenderer.sprite = sprites[2]; 
        }
        else if (verticalInput < 0) 
        {
            spriteRenderer.sprite = sprites[3]; 
        }
    }
}