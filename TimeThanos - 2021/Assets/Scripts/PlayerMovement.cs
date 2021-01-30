using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float camDir = 0;
    public Transform cam;
    public float rotSpeed;
    public float movSpeed;
    private Vector2 dir;

    private Animator anim;

    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    void FixedUpdate()

    {

        camDir += Input.GetAxis("Mouse X") * Time.deltaTime * rotSpeed;

        transform.rotation = Quaternion.Euler(0, camDir, 0);

        dir = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        dir = Vector2.ClampMagnitude(dir, 1);

        Vector3 camF = cam.forward;
        Vector3 camR = cam.right;

        camF.y = 0;
        camR.y = 0;
        camF = camF.normalized;
        camR = camR.normalized;

        transform.position += (camF * dir.y + camR * dir.x) * Time.deltaTime * movSpeed;

        if(Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0)
        {
            anim.SetBool("run", false);
        }else {
            anim.SetBool("run", true);
        }

    }

}