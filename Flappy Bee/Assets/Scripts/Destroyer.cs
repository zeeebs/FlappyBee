using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Destroyer : MonoBehaviour 
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        GameOver();
    }

        void GameOver()
    {
        SceneManager.LoadScene(2);
    }
        
}
