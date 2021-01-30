using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    public int point;

    PointSystem pointSystemScript = PointSystem.Instance;

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Other") {
            pointSystemScript.GivePonto(point);
        }
    }
}
