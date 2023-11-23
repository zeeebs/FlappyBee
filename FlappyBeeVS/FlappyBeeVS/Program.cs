using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.SceneManagement;
using static System.Runtime.CompilerServices.RuntimeHelpers;

public class PlayerControlls : MonoBehaviour
{
    Rigidbody rigidBody;
    SpriteRenderer spriteRenderer;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }
    void Update()
    {


        if (transform.position.y <= -4.3f)
        {
            transform.position = new Vector3(transform.position.x, -4.3f, 0);
        }

        if (transform.position.x >= 7.5f)
        {
            transform.position = new Vector3(7.5f, transform.position.y, 0);
        }

        else if (transform.position.x <= -7.5f)
        {
            transform.position = new Vector3(-7.5f, transform.position.y, 0);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow)) //left
        {
            transform.Translate(-Vector3.right * distance);

        }

        if (Input.GetKeyDown(KeyCode.RightArrow)) //right
        {
            transform.Translate(Vector3.right * distance);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow)) //down
        {
            transform.Translate(-Vector3.up * distance);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow)) //up
        {
            transform.Translate(Vector3.up * distance);
        }

    }

}