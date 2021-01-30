using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawn : MonoBehaviour
{
	[SerializeField]
	private GameObject[] SpawnPoints;
	[SerializeField]
	private GameObject ItemType;
	[SerializeField]
	private GameObject Mushroom;
	[SerializeField]
	private int ItemQuantity;

	private void Start()
	{
		if (SpawnPoints.Length < ItemQuantity)
			Debug.LogError("There must be more Spawn Points for itens than quantity of itens in the level.");
		else
			SpawnItem();
	}

	private void SpawnItem()
	{
		int[] positions = RandomNumbers(ItemQuantity, SpawnPoints.Length);
		int j = 0;

		for (int i = 0; i < SpawnPoints.Length; i++)
		{
			if (i == positions[j] && j < SpawnPoints.Length)
			{
				Instantiate(ItemType, SpawnPoints[i].transform);
				j++;
			}
			else
				Instantiate(Mushroom, SpawnPoints[i].transform);
		}
	}

	private int[] RandomNumbers(int qty, int max)
	{
		List <int> list = new List<int>(new int[max]);

		for (int i = 0; i < qty; i++)
		{
			int temp = Random.Range(0, max);

			while (list.Contains(temp))
				temp = Random.Range(0, max);

			list[i] = temp;
		}

		return list.ToArray();
	}
}
