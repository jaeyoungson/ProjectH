using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temp_Monster : MonoBehaviour
{
    private Vector3 target;
    private float dampSpeed = 1.0f;

    void Start()
    {
        target = GameObject.FindWithTag("Player").transform.position;
    }

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target, Time.deltaTime * dampSpeed);
    }
}
