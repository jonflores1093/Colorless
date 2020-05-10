using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    PlayerController pc;

    void onTriggerEnter2D(Collider2D Collider)
    {


        Scene sceneCurrent = SceneManager.GetActiveScene();

        string sceneName = sceneCurrent.name;

        if (sceneName == "World 1")
        {
            SceneManager.LoadScene("World 2");
        }

        else if (sceneName == "World 2")
        {
            SceneManager.LoadScene("World 3");
        }
        else if (sceneName == "World 3")
        {
            SceneManager.LoadScene("Menu");
            Cursor.lockState = CursorLockMode.None;
        }

    }
}
