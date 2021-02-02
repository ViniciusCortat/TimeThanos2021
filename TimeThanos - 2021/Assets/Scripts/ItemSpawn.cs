using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawn : MonoBehaviour
{
	[SerializeField]
	private List<GameObject> SpawnPoints;
	[SerializeField]
	private GameObject ItemType;
	[SerializeField]
	private GameObject OtherItem;
	[SerializeField]
	private int ItemQuantity;

	private void Start()
	{
		if (SpawnPoints.Count < ItemQuantity) {
			
		}
		else
			SpawnItem2();
	}

	private void SpawnItem()
	{
		int[] positions = RandomNumbers(ItemQuantity, SpawnPoints.Count);
		int j = 0;

		for (int i = 0; i < SpawnPoints.Count; i++)
		{
			if (i == positions[j] && j < SpawnPoints.Count)
			{
				Instantiate(ItemType, SpawnPoints[i].transform);
				j++;
			}
			else
				Instantiate(OtherItem, SpawnPoints[i].transform);
		}
	}

	private void SpawnItem2() {
		List<int> pos = new List<int>();
		int rnd;

		for(int i=0;i<ItemQuantity;i++) {
			rnd = Random.Range(0,SpawnPoints.Count);
			while(pos.Contains(rnd)) {
				rnd = Random.Range(0,SpawnPoints.Count);
			}

			pos.Add(rnd);
		}

		pos.Sort();

		int k = 0;

		for(int j=0;j<SpawnPoints.Count;j++) {
			if(k < pos.Count && j == pos[k]) {
				Instantiate(ItemType, SpawnPoints[j].transform);
				k++;
			}
			else {
				Instantiate(OtherItem, SpawnPoints[j].transform);
			}
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
