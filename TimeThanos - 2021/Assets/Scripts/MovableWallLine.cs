using System.Collections;
using UnityEngine;

public class MovableWallLine : MonoBehaviour
{
	[SerializeField]
	private GameObject Wall;
	[SerializeField]
	private Transform StartPoint;
	[SerializeField]
	private Transform FinalPoint;

	[SerializeField]
	private float WaitTime = 30f;

	private bool _isActive = false;

	public AudioSource audio;

	private void Start()
	{
		InvokeRepeating("ChoosePoint", WaitTime, WaitTime);
		WaitTime += Feiticos.Wall;
	}

	private void ChoosePoint()
	{
		if (_isActive)
			StartCoroutine(MoveWall(StartPoint.position, 2));
		else
			StartCoroutine(MoveWall(FinalPoint.position, 2));
	}

	IEnumerator MoveWall(Vector3 targetPosition, float duration)
	{
		audio.Play();
		float time = 0;
		Vector3 startPosition = Wall.transform.position;

		while (time < duration)
		{
			Wall.transform.position = Vector3.Lerp(startPosition, targetPosition, time / duration);
			time += Time.deltaTime;
			yield return null;
		}
		Wall.transform.position = targetPosition;

		_isActive = !_isActive;
	}
}
