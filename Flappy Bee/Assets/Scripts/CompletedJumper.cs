using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompletedJumper : MonoBehaviour
{
    // variables for a Rigidbody2D and a float that we can set in the inspector
    // public means it is shown in the inspector
    // "Rigidbody2D" and "float" are the type of variable
    // "body" and "jumpAmount" are the custom names we give the variables
    public Rigidbody2D body;
    public float jumpAmount = 5;


    // Update is called once per frame
    public float Jump()
    {
        // if we pressed space this frame OR if we left-clicked this frame...
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            // ... then set the velocity of our Rigidbody2D to up, with a magnitude of jumpAmount
            body.velocity = new Vector2(0, jumpAmount);
        }
        return jumpAmount;
    }
}
