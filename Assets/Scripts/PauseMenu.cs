using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
	
	[SerializeField] private GameObject pauseButton;

	[SerializeField] private GameObject pauseMenu;
	
	[SerializeField] private GameObject levelWonPanel;

	public void Pause()
	{
		Time.timeScale = 0f;			
		pauseButton.SetActive(false);	
		pauseMenu.SetActive(true);

	}


	public void Resume()
	{
		Time.timeScale = 1f;
		pauseButton.SetActive(true);
		pauseMenu.SetActive(false);
		
	}

	
	public void Restart()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}


	public void exitToMenuYes()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
	}

	public void nextLevel()
	{
		Time.timeScale = 1f;
		levelWonPanel.SetActive(false);
		SceneManager.LoadScene("LevelONE", LoadSceneMode.Single);
		Debug.Log("Siguiente Nivel");
	}
}
