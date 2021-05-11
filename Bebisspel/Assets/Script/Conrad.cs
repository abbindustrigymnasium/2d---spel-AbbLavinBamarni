using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conrad : MonoBehaviour {
   
    public GameObject gameoverText;
    public GameObject restartButton;
    public GameObject congratulationsText;
    public GameObject RestartButton;
    public GameObject PlayAgainButton;
    public GameObject PlayAgainText;
    public GameObject BackButton;
    
    public float speed = 2;
    public float force = 300;

    
    void Start () 
    {    
        gameoverText.SetActive(false);
        restartButton.SetActive(false);
        congratulationsText.SetActive(false);
        RestartButton.SetActive(false);
        BackButton.SetActive(false);

                
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;

    }
   
    
    void Update () 
    {
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);

    }


   void OnTriggerEnter2D (Collider2D col)
   {
       switch (col.gameObject.tag) 
            {
                case "Duck 1":
                TimeLeftscript.TimeLefttext += 1f;
                col.gameObject.SetActive (false);
                break;
                case "Cat":
                TimeLeftscript.TimeLefttext -= 2f;
                col.gameObject.SetActive (false);
                break;
            }
   }

    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "SpecialDucky")
        {
            congratulationsText.SetActive(true);
            PlayAgainText.SetActive(true);
            PlayAgainButton.SetActive(true);
            BackButton.SetActive(true);
            Destroy(gameObject);
        }
        else
        { 
            gameoverText.SetActive(true);
            restartButton.SetActive(true);
            RestartButton.SetActive(true);
            BackButton.SetActive(true);
            Destroy(gameObject);
        }
        
       


    }


}


