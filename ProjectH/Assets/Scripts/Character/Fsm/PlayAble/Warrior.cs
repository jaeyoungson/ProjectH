using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Global_Define;

public class Warrior : Character
{
    private void Awake()
    {     
        playLogic.AddFsm(new PlayUpdate(gameObject));
        SetPlayAble(true);
        playLogic.SetState(PlayAbleLogic.PlayUpdate);
    }

    private new void Update()
    {        
        base.Update();
    }
}
