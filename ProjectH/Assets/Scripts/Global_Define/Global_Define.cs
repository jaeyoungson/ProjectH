using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Global_Define
{
    #region enum

    public enum PlayAbleLogic
    {
        PlayUpdate = 1,

    }
    public enum NonPlayLogic   
    {

    }

    public enum PlayCharacter
    {
        Warrior=0,
        Mage,
        Archer
    }

    public enum CharacterState
    {
        Idle=0,
        Move,
        Skill,
        Stiffen,
        Down,
        WakeUp,
        Recovery,

    }

    public enum SpState//슈퍼아머나 무적상태 값
    {
        None =0,
        Invincible, //무적상태
        SuperArmor
    }

    public enum BerserkerState
    {

    }

    public enum MageState
    {

    }

    public enum ArcherState
    {

    }
    
    #endregion
}
