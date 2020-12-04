using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class MainMenu : MonoBehaviour
{

    private DateTime sceneTime = 18:30:00f;

    public void PlayGame()
    {
        TimeZoneInfo cst = TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time");
        System.DateTime today = System.DateTime.Now;
        DateTime currentTime = TimeZoneInfo.ConvertTime(today, cst);
        Debug.Log(currentTime);

        if (currentTime == 18:12:00)
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


        }



    }

    public void QuitGame()
    {

        Application.Quit();

    }

    public void Restart()
    {

        SceneManager.LoadScene("Menu");

    }



    




}
