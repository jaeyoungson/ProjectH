using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Global_Define;

public class PlayableCharacter : Character
{
    public bool playingCharacter;   //true 플레이중 false nonplay
    public List<Character> monsterList;
    private CharacterState state =default;
    
    public int exp;
    public int next_Exp;
    // Update is called once per frame
    void Update()
    {
        if(playingCharacter==false)
        {
            switch (state)
            {
                case CharacterState.Idle:
                    break;
                case CharacterState.Run:
                    break;
                case CharacterState.Move:
                    break;
                case CharacterState.Battle:   
                    break;
                case CharacterState.Stiffen:
                    break;
                case CharacterState.Down:
                    break;
                case CharacterState.WakeUp:
                    break;
                case CharacterState.Recovery:
                    break;
                default:
                    break;
            }
        }
    }
    #region protected virtual
    protected virtual void Idle() { }
    protected virtual void Move() { }
    #endregion

    #region public virtual
    public virtual void NormalSkill()      { }
    public virtual void SkillNumberOne()   { }
    public virtual void SkillNumberTwo()   { }
    public virtual void SkillNumberThree() { }
    public virtual void EvasionSkill()     { }
    public virtual void UltimateSkill()    { }
    public virtual void CooperationSkill() { }
    #endregion
}
