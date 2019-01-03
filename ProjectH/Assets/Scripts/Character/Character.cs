using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Global_Define;

public class Character : MonoBehaviour
{
    private bool playAble;  //true 플레이가능 flase 플레이 불가능
    public float moveSpeed;

    #region get
    public bool getPlayAble
    {
        get { return playAble; }
    }
    #endregion

    #region set
    public void SetPlayAble(bool play)
    {
        playAble = play;    
    }
    #endregion

    private void Awake()
    {
        //로직을 추가함
    }

} 
