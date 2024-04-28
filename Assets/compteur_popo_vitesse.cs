using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class compteur_popo_vitesse : MonoBehaviour
{
    [SerializeField] public Text vitess_counter;

    private int vitess = 0;

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

        if (other.CompareTag("vitess"))
        {
            vitess += 1;
            vitess_counter.text = "" + vitess;
            Destroy(other.gameObject);
        }
    }

}
