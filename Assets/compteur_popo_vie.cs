using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class compteur_popo_vie : MonoBehaviour
{
    [SerializeField] public Text vie_counter;

    private int vie = 0;

    private Rigidbody2D rbody;
    private BoxCollider col;

    private void Start()
    {
        DontDestroyOnLoad(this);
        rbody = GetComponent<Rigidbody2D>();
        col = GetComponent<BoxCollider>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("vie"))
        {
            vie += 1;
            vie_counter.text = "" + vie;
            Destroy(other.gameObject);
        }
    }

}
