# FlappyBee
<p id="Page Top">
Recreation of the Smart Phone Game: Flappy Bird

This project was created using C# and Unity. It showcases player input for movement, enemy collisions, life counter, scene switches, sound effects and music, and custom graphics. 

I created this project with the help of Indie Game Academy's secret Level 0 course, which can be accessed once an individual is signed up to receive their emails.

<ul>
<li><a href="#Player Controlls">Player Controlls</a></li>
<li><a href="#Player Movement">Player Movement</a></li>
<li><a href="#Enemy Collision">Enemy Collision</a></li>
<li><a href="#PipeController">"Pipe" Controller</a></li>
<li><a href="#Other Skills">Other Skills</a></li>
<li><a href="#Images">Images</a></li>
 </ul>
 </p>
 
<hr class="dashed">

<p id="Player Controlls">
<h3>Player Controlls</h3>

The player only moves up and down through "jumping", triggered by the space bar. The player stays in one spot and the obstacles move around it.

```
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
```
</p>

<p id="Player Movement">
<h3>Player Movement</h3>
  
```
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompletedJumper : MonoBehaviour
{
    public Rigidbody2D body;
    public float jumpAmount = 5;

    public float Jump()
    {     
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            body.velocity = new Vector2(0, jumpAmount);
        }
        return jumpAmount;
    }
}

```
</p>

<p id="Enemy Collisons">
<h3>Enemy Collisions</h3>
When the player hits a log, the game is over.
     
```
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
```
```
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

```
</p>
<p id="PipeController">    
<h3>"Pipe" Controller</h3>

The logs move to the left to simulate the player moving.

```
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour 
{
    public float speed = -0.025f;
    public float xBound = -20f;
    public float xRestart = 20f;
    public float yVariation = 2f;

    private float yStart;

    public void Start()
    {
        yStart = transform.position.y;

        Vector3 newPosition = GetComponent<Transform>().position;
        newPosition.y = yStart + Random.Range(-yVariation, yVariation);
        GetComponent<Transform>().position = newPosition;
    }

    // Update is called once per frame
    void Update () 
    {
        Vector3 newPosition = GetComponent<Transform>().position;

        newPosition.x += speed;

        if( newPosition.x < xBound )
        {
            newPosition.x = xRestart;

            //***** Extra content! *****
            newPosition.y = yStart + Random.Range(-yVariation, yVariation);
        }

        GetComponent<Transform>().position = newPosition;
    }
}

```
</p>
<p id="Other Skills">
<h3>Other Skills</h3>
<ul>
<li>This was my first game completed without help from a live person. With the Tech Academy Bootcamp, I had instructors I could ask for help if I really got stuck. This game was different in that I had to find the asnswers to my questions completely on my own.</li>

</ul>

</p>
<p id="Images">
<h3>Images</h3>

Lastly, here are some images from the final product. All the artwork was self-made using Procreate.

![Main Menu](https://github.com/zeeebs/FlappyBee/blob/main/Flappy%20Bee/ReadMeImages/MainMenu.png)

![Game Play](https://github.com/zeeebs/FlappyBee/blob/main/Flappy%20Bee/ReadMeImages/GamePlay.png)

![Game Over](https://github.com/zeeebs/FlappyBee/blob/main/Flappy%20Bee/ReadMeImages/GameOver.png)


  
<h4><a href="#Player Controlls">Player Controlls</a>, <a href="#Player Movement">Player Movement</a>, <a href="#Enemy Collision">Enemy Collision</a>, <a href="#PipeController">"Pipe" Controller</a>, <a href="#Other Skills">Other Skills</a>, <a href="#Images">Images</a>, <a href="#Page Top">Page Top</a></h4>
