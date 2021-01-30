using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableWallRotation : MonoBehaviour
{
	[SerializeField]
	private GameObject Pivot;
	[SerializeField]
	private float WaitTime = 30f;
	[SerializeField]
	private bool InvertRotation = false;

	private bool _isActive = false;
	private Quaternion RotClockwise = Quaternion.Euler(0, 90, 0);
	private Quaternion RotAntiClockwise = Quaternion.Euler(0, -90, 0);
	private Quaternion RotInitialPos = Quaternion.Euler(0, 0, 0);

	private void Start()
	{
		InvokeRepeating("ChoosePoint", WaitTime, WaitTime);
		WaitTime += Feiticos.Wall;
	}

	private void ChoosePoint()
	{
		if (_isActive)
			StartCoroutine(MoveWall(RotInitialPos));
		else
		{
			if (InvertRotation)
				StartCoroutine(MoveWall(RotAntiClockwise));
			else
				StartCoroutine(MoveWall(RotClockwise));
		}
	}

	IEnumerator MoveWall(Quaternion rotation)
	{
		while (Pivot.transform.rotation != rotation)
		{
			Pivot.transform.rotation = Quaternion.Lerp(Pivot.transform.rotation, rotation, Time.deltaTime);
			//yield return new WaitForEndOfFrame();
			yield return null;
		}

		_isActive = !_isActive;
	}
}
