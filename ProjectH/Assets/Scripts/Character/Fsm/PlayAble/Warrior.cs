using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Global_Define;

public class Warrior : Character
{
    GameObject playGameObject;
    private void Awake()
    {
        playLogic.AddFsm(new PlayUpdate());
        SetPlayAble(true);
        playLogic.SetState(PlayAbleLogic.PlayUpdate);
        playGameObject = GameManager.Ins.getCurPlayCharacter;
    }


    private new void Update()
    {        
        base.Update();
    }
}
