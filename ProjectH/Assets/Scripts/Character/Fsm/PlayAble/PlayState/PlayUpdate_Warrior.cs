using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Global_Define;

public class PlayUpdate_Warrior : Fsm_State<PlayAbleLogic>
{
    public GameObject playGameObject;
    public PlayUpdate_Warrior (GameObject playObject): base(PlayAbleLogic.PlayUpdate)
    {
        playGameObject = playObject;
    }
    float moveSpeed = 5.0f;
     
    // Update is called once per frame
    public void Update()
    {
        float translationZ = Input.GetAxis("Vertical") * moveSpeed;
        float translationX = Input.GetAxis("Horizontal") * moveSpeed;

        translationX *= Time.deltaTime;
        translationZ *= Time.deltaTime;

        playGameObject.transform.Translate(translationX, playGameObject.transform.position.y, translationZ);
    }
}