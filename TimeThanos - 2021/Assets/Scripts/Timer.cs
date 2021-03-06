using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
	[Tooltip("Tempo em segundos")]
	public float timeRemaining = 10;

	public TextMeshProUGUI TimerTextTMP;
	private bool timeStopped = false;

	private void Start()
	{
		timeRemaining += Feiticos.Time;

		if (Feiticos.TimeUI == true)
		{
			TimerTextTMP.gameObject.SetActive(false);
		}
		else
		{
			TimerTextTMP.gameObject.SetActive(true);
		}
	}

	void Update()
	{
		if (timeRemaining > 0)
			timeRemaining -= Time.deltaTime;
		else
		{
			timeRemaining = 0;
			timeStopped = true;
			SceneManager.LoadScene("Mae");
			AudioManager.sharedInstance.StopTema();
			AudioManager.sharedInstance.PlayTimeOut();
		}

		DisplayTime(timeRemaining);
	}

	void DisplayTime(float time)
	{
		if (!timeStopped)
			time += 1;

		float min = Mathf.FloorToInt(time / 60);
		float sec = Mathf.FloorToInt(time % 60);

		TimerTextTMP.text = string.Format("{00:00}:{1:00}", min, sec);
	}
}
