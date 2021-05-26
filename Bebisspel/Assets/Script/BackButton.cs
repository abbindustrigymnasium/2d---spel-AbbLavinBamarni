using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{

    //changes scene
    public void LoadScene(string MainMenu) {
        SceneManager.LoadScene(MainMenu);
    }

    

}
