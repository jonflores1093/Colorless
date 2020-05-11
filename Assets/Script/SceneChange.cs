using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    [SerializeField] private string nextSceneName;


    private void onTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(nextSceneName);
        Debug.Log("Working");
        
    }
}
