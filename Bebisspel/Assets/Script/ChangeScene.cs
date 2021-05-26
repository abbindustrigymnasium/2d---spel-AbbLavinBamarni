using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    //Changes scene
    public void LoadScene(string MainMenu) {
        SceneManager.LoadScene(MainMenu);
    }

    
}
