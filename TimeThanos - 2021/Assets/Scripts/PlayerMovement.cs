using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;
    public float rotSpeet;
    private Quaternion Rotation => Quaternion.LookRotation(Vector3.Normalize(Direction())); 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float translationV = 0;
        float translationH = 0;

        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            translationV = Input.GetAxisRaw("Vertical") * moveSpeed;
            translationH = Input.GetAxisRaw("Horizontal") * moveSpeed;
        }


        translationV *= Time.deltaTime;
        translationH *= Time.deltaTime;

        transform.rotation = Rotation;

        transform.position += Vector3.Normalize(Direction()) * moveSpeed * Time.deltaTime;
    }

    private Vector3 Direction()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        return new Vector3(h, 0, v);
    }
}
