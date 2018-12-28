using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Global_Define;

public class PlayUpdate : Fsm_State<PlayAbleLogic>
{
    PlayUpdate_Warrior warrior;
    GameObject playgameObject;
    
    public  PlayUpdate(GameObject playObject): base(PlayAbleLogic.PlayUpdate)
    {
        playgameObject = playObject;
        warrior = new PlayUpdate_Warrior(playgameObject);
    }

    public override void Enter()
    {
        //상태 진입시 해야할점
    }

    public override void Update()
    {
        //상태내내 업데이트 해야하는 부분
        //현재 플레이어가 어떤 케릭터를 조종하고있는지 확인해야함
        warrior.Update();
    }

    public override void End()
    {
        //상태가 끝이나고 행동하는 부분        
    }
}
