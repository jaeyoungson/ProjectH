using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayUpdate_Warrior : MonoBehaviour
{
    float moveSpeed = 5.0f;
    // Update is called once per frame
    public void Update()
    {
        float translationZ = Input.GetAxis("Vertical") * moveSpeed;
        float translationX = Input.GetAxis("Horizontal") * moveSpeed;

        translationX *= Time.deltaTime;
        translationZ *= Time.deltaTime;

        GameManager.Ins.curPlayCharacter.transform.Translate(translationX, GameManager.Ins.curPlayCharacter.transform.position.y, translationZ);
    }
}
