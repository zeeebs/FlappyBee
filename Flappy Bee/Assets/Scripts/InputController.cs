using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;


public class InputController : MonoBehaviour
{
    //jump controller
    public CompletedJumper controlledJumper;

    //for score keeper
    private int Points = 0;
    public Text ScoreText;
   

    //jump controller
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            controlledJumper.Jump();
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

