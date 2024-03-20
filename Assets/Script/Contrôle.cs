using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed = 5f; // Vitesse de déplacement du personnage
    private Rigidbody2D rb; // Référence au Rigidbody2D

    void Start()
    {
        // Au démarrage du jeu, on récupère le Rigidbody2D attaché au personnage
        rb = GetComponent<Rigidbody2D>();

     
    }

    void Update()
    {
        // À chaque image affichée à l'écran, on vérifie les entrées du joueur

        // Mouvement horizontal (gauche/droite)
        float horizontalInput = Input.GetAxis("Horizontal");

        // Mouvement vertical (haut/bas)
        float verticalInput = Input.GetAxis("Vertical");

        // On crée un vecteur de mouvement en fonction des entrées du joueur
        Vector2 movement = new Vector2(horizontalInput, verticalInput);

        // Si le vecteur de mouvement n'est pas nul, on applique la vélocité
        if (movement != Vector2.zero)
        {
            // On multiplie le vecteur de mouvement par la vitesse pour obtenir la vélocité
            Vector2 velocity = movement * speed;

            // On applique cette vélocité au Rigidbody2D pour que le personnage se déplace
            rb.velocity = velocity;
        }
        else
        {
            // Si aucune touche n'est pressée, on arrête le déplacement
            rb.velocity = Vector2.zero;
        }
    }
}