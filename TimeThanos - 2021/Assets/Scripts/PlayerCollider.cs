using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    [SerializeField]
    private int point;
    [SerializeField]
    private GameObject InputText;

    PointSystem pointSystemScript = PointSystem.Instance;

	private void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.tag == "Collectible")
		{
            InputText.SetActive(true);
		}
	}

	private void OnTriggerStay(Collider col)
	{
		if (col.gameObject.tag == "Collectible")
		{
			if (Input.GetKeyDown(KeyCode.E))
			{
				pointSystemScript.GivePonto(col.GetComponent<ItemValue>().Value);
				Destroy(col.gameObject);
			}
		}
	}

	private void OnTriggerExit(Collider col)
	{
			InputText.SetActive(false);
	}
}
