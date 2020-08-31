using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public Text newText; //Get text GameObject

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Determine if the player is pressing the space
        if (Input.GetKeyDown("space"))
        {
            //The text will change in the game once the player presses the spacebar
            newText.text = "Hello, my name is Brandon Perez.";
        }

        //Enable the player to quit the game by pressing escape
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
