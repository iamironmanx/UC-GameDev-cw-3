using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartscript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("Lvl1");
        //before you rename the scene Lvl1 , save the game on unity
        //and itll reload the scene
        //or load scene(0)
    }
}
