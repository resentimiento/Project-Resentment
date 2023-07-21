using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public void PlayLevelOne()
    {
        SceneManager.LoadScene("LevelONE");
    }


    public void PlayLevelTwo()
    {
        SceneManager.LoadScene("LevelTWO");
    }



    public void PlayLevelThree()
    {
        SceneManager.LoadScene("LevelTHREE");
    }


}
