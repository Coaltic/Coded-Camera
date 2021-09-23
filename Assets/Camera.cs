using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform cube;

    public Vector3 movement = new Vector3();
    public Vector3 startPosition1;
    public Vector3 startPosition2;
    public Vector3 startPosition3;
    public float speed = 3;
    public float amount = 0.5f;

    public bool cam1 = true;
    public bool cam2 = false;
    public bool cam3 = false;


    void Start()
    {
        startPosition1 = transform.position;
        startPosition2 = new Vector3(-25.0f, 7.0f, 5.0f);
        startPosition3 = new Vector3(20.0f, 7.0f, 2.0f);
    }

    // Update is called once per frame
    
    void Update()
    {
        if (cam1)
        {
            movement = transform.position;
            movement.y = startPosition1.y + (Mathf.Sin(Time.time * speed) * amount);
            transform.position = movement;
            transform.LookAt(cube);
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
        }

        if (cam2)
        {

            movement = transform.position;
            movement.x = startPosition2.x + (Mathf.Sin(Time.time * speed) * amount);
            transform.position = movement;
            transform.LookAt(cube);
            transform.Translate(Vector3.up * speed * Time.deltaTime, Space.World);
        }

        if (cam3)
        {

            movement = transform.position;
            movement.y = startPosition3.y + (Mathf.Sin(Time.time * speed) * amount);
            transform.position = movement;
            transform.LookAt(cube);
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
        }
    }

    public void Cam1()
    {
        transform.position = startPosition1;
        cam1 = true;
        cam2 = false;
        cam3 = false;
    }
    public void Cam2()
    {
        transform.position = startPosition2;
        cam1 = false;
        cam2 = true;
        cam3 = false;
    }
    public void Cam3()
    {
        transform.position = startPosition3;
        cam1 = false;
        cam2 = false;
        cam3 = true;
    }
}


