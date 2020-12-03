using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class SceneChange : MonoBehaviour
{

    [SerializeField] private string nextSceneName;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(nextSceneName);
        
        
    }


   




}
