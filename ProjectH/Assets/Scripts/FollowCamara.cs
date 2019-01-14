﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamara : MonoBehaviour
{

    public PlayableCharacter target;
    public float cameraMoveSpeed;
    public float cameraRotateSpeed;
    public float distanceFromTarget;
    public float height;
    public float targetOffset;

    private Transform rigTransform;

    // Start is called before the first frame update
    void Start()
    {
        rigTransform = transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        target = BattleManager.Ins.curPlayCharacter.GetComponent<PlayableCharacter>();

        var camPosition = target.transform.position - (target.transform.forward * distanceFromTarget) + (target.transform.up * height);

        rigTransform.position = Vector3.Slerp(rigTransform.position, camPosition, Time.deltaTime * cameraMoveSpeed);

        rigTransform.rotation = Quaternion.Slerp(rigTransform.rotation, target.transform.rotation, Time.deltaTime * cameraRotateSpeed);

        rigTransform.LookAt(target.transform.position + (Vector3.up * targetOffset));
    }
}
