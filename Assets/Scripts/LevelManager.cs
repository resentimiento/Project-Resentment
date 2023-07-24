using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public void PlayLevelOne()
    {
        SceneManager.LoadScene("LevelONE", LoadSceneMode.Single);
    }


    public void PlayLevelTwo()
    {
        SceneManager.LoadScene("LevelTWO", LoadSceneMode.Single);
    }



    public void PlayLevelThree()
    {
        SceneManager.LoadScene("LevelTHREE", LoadSceneMode.Single);
    }


}
