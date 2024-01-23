using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InputController : MonoBehaviour
{
    //jump controller
    public CompletedJumper controlledJumper;

    //for score keeper
    private int Points = 0;
    public Text ScoreText;


    void GameOver()
    {
        SceneManager.LoadScene(2);
    }
    //jump controller
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            controlledJumper.Jump();
        }

        if (transform.position.y <= -4.68)
        {
            GameOver();
        }
    }
    //score keeper
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("LogScore"))
        {
            Points++;
            ScoreText.text = Points.ToString();
            //incremement a point
        }
    }
}

