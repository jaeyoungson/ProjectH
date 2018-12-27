using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Global_Define;

public class Character : MonoBehaviour
{
    private bool playAble;  //true 플레이가능 flase 플레이 불가능
    public Fsm_Class<PlayAbleLogic> playLogic = new Fsm_Class<PlayAbleLogic>();
    public Fsm_Class<NonPlayLogic> nonPlayLogic = new Fsm_Class<NonPlayLogic>();


    public bool getPlayAble
    {
        get { return playAble; }
    }

    public void SetPlayAble(bool play)
    {
        playAble = play;    
    }

    private void Awake()
    {
        //로직을 추가함
    }

    protected void Update()
    {
        if(playAble && playLogic!= null)
        {
            playLogic.Update();
        }
        else
        {
            nonPlayLogic.Update();
        }

    }
}
