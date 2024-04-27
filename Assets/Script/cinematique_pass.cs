using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cinematique_pass : MonoBehaviour
{
    public void debut_jeu()
    {
        SceneManager.LoadSceneAsync(2);
    }
}
