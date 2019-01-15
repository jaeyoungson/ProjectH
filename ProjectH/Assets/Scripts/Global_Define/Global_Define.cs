﻿using System.Collections;
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
        Berserker=0,
        Mage,
        Archer,
        Monster,
        Npc
    }
    public enum CharacterTargetType
    {
        None = 0,
        Playable,
        Monster,
    }


    public enum CharacterState
    {
        Idle=0,
        Move,
        Run,
        Skill,
        Skilling,
        Stiffen,
        Down,
        WakeUp,
        Recovery,
    }

    public enum AbnormalConditionState
    {
        None = 0,
        Poison =1,
        Bleeding,
        E_Shock,
        Stun,
        SuperArmor,
        Invincible,
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

    public enum TargetObject_Type
    {
        None=0,
        PlayableCharacter,
        Monster,
    }

    #endregion
}
