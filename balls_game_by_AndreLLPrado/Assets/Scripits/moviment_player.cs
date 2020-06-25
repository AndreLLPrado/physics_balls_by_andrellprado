using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
//using System.Numerics;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]

public class moviment_player : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    public float speed = 6.0f;
    float rotX, rotY;

    GameObject cameraFPS;
    Vector3 moveDirection = Vector3.zero;
    CharacterController controller;
    void Start()
    {
        transform.tag = "Player";
        cameraFPS = GameObject.Find("camera");
        cameraFPS.transform.rotation = Quaternion.identity;
        cameraFPS.transform.localPosition = new Vector3(0, 1, 0);
        cameraFPS.transform.localRotation = Quaternion.identity;
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 frontDirection = new Vector3(cameraFPS.transform.forward.x,0, cameraFPS.transform.forward.z);
        Vector3 sidetDirection = new Vector3(cameraFPS.transform.right.x, 0, cameraFPS.transform.right.z);
        frontDirection.Normalize();
        sidetDirection.Normalize();

        frontDirection = frontDirection * Input.GetAxis("Vertical");
        sidetDirection = sidetDirection * Input.GetAxis("Horizontal");

        Vector3 finalDirection = frontDirection + sidetDirection;
        if(finalDirection.sqrMagnitude > 1)
        {
            finalDirection.Normalize();
        }

        if (controller.isGrounded)
        {
            moveDirection = new Vector3(finalDirection.x, 0, finalDirection.z);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = 8.0f;
            }
        }


        moveDirection.y -= 20.0f * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
        FPSCam();
    }

    void FPSCam()
    {
        rotX += Input.GetAxis("Mouse X") * 5.0f;
        rotY += Input.GetAxis("Mouse Y") * 5.0f;

        rotX = ClampAngleFPS(rotX, -360, 360);
        rotY = ClampAngleFPS(rotY, -80, 80);

        Quaternion xQuaternion = Quaternion.AngleAxis(rotX, Vector3.up);
        Quaternion yQuaternion = Quaternion.AngleAxis(rotY, -Vector3.right);
        Quaternion finalRotate = Quaternion.identity * xQuaternion * yQuaternion;

        cameraFPS.transform.rotation = Quaternion.Lerp(cameraFPS.transform.rotation, finalRotate, Time.deltaTime * 10.0f);

    }

    float ClampAngleFPS(float angle, float min, float max)
    {
        if (angle < -360)
        {
            angle += 360;
        }

        if (angle > 360)
        {
            angle -= 360;
        }
        return Mathf.Clamp(angle, min, max);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "BallReloader")
        {
            GetComponentInChildren<lauch_ball>().attempt = 10;
            Destroy(other.gameObject);

            Destroy(other);
        }
    }
}
