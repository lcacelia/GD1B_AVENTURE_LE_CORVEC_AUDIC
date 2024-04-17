using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class compteurdepiece : MonoBehaviour
{
    [SerializeField] public Text piece_counter;

    private int piece = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Collectible"))
        {
            piece += 1;
            piece_counter.text = "" + piece;
            Destroy(other.gameObject);
        }
    }

}
