using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cinematique_fin : MonoBehaviour
{
    public void fin_jeu()
    {
        SceneManager.LoadSceneAsync(0);
    }
}

