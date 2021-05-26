using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conrad : MonoBehaviour {
   
    //Public means that anything anywhere has direct access to whatever it is, 
    //You can edit the value from the inspector if you wanna build a variable which uses your control avoid it in private
    public GameObject gameoverText;
    public GameObject restartButton;
    public GameObject congratulationsText;
    public GameObject RestartButton;
    public GameObject PlayAgainButton;
    public GameObject PlayAgainText;
    public GameObject BackButton;
    
    public float speed = 2; //the speed it moves forward with
    public float force = 300; //the power it moves forward with 

    
    void Start () 
    {    
        //When set false it does not show in the beggining it only shows when its programmed to
        gameoverText.SetActive(false);
        restartButton.SetActive(false);
        congratulationsText.SetActive(false);
        RestartButton.SetActive(false);
        BackButton.SetActive(false);

                
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed; //commands it to move a certain way

    }
   
    
    void Update () 
    {
        //Which key to use in the game 
        if (Input.GetKeyDown(KeyCode.UpArrow))
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);

    }



    void OnCollisionEnter2D(Collision2D col) {
        //When gameobject "bebis" collides with "SpecialDucky", all commands before "else" is set true, which means they will show
        if (col.gameObject.tag == "SpecialDucky")
        {
            congratulationsText.SetActive(true);
            PlayAgainText.SetActive(true);
            PlayAgainButton.SetActive(true);
            BackButton.SetActive(true);
            Destroy(gameObject); //destroys gameObject
        }
        //If gameObject collides with a different object, the commands below else will show instead
        else
        { 
            gameoverText.SetActive(true);
            restartButton.SetActive(true);
            RestartButton.SetActive(true);
            BackButton.SetActive(true);
            Destroy(gameObject); //destroys gameObject
        }
        
       


    }


}


