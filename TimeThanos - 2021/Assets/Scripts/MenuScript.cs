using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
	private PointSystem PS;

	private void Start()
	{
		PS = PointSystem.Instance;
	}

	public void StartGame()
	{
		AudioManager.sharedInstance.PlayUISound();
		SceneManager.LoadScene("Game", LoadSceneMode.Single);
		PS.ResetPonto();
	}

	public void Leaderboard()
	{
		AudioManager.sharedInstance.PlayUISound();
		SceneManager.LoadScene("ResultadoFinal", LoadSceneMode.Single);
	}

	public void GoMenu()
	{
		AudioManager.sharedInstance.PlayUISound();
		SceneManager.LoadScene("Menu", LoadSceneMode.Single);
		Time.timeScale = 1f;
	}

	public void Settings()
	{
		AudioManager.sharedInstance.PlayUISound();
		SceneManager.LoadScene("Settings", LoadSceneMode.Single);
	}

	public void Achievements()
	{
		AudioManager.sharedInstance.PlayUISound();
		SceneManager.LoadScene("Achievements", LoadSceneMode.Single);
	}

	public void Customize()
	{
		AudioManager.sharedInstance.PlayUISound();
		SceneManager.LoadScene("Customizar", LoadSceneMode.Single);
	}

	public void Reload()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
		Time.timeScale = 1f;
		PS.ResetPonto();
	}

	public void QuitGame()
	{
		Debug.Log("SAIR");
		Application.Quit();
	}

	public void NewGame()
	{
		AudioManager.sharedInstance.PlayUISound();
		SaveSystem.GetInstance().NewGame();
	}

	public void PlaySoundOnly()
	{
		AudioManager.sharedInstance.PlayUISound();
	}
}
