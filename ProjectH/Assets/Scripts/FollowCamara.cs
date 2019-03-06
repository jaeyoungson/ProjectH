using System.Collections;
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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        target = BattleManager.Ins.curPlayCharacter.GetComponent<PlayableCharacter>();

        var camPosition = target.transform.position - (Vector3.forward * distanceFromTarget) + (target.transform.up * height);

        transform.position = Vector3.Slerp(transform.position, camPosition, Time.deltaTime * cameraMoveSpeed);
                
        transform.LookAt(target.transform.position + (Vector3.up * targetOffset));
    }
}
