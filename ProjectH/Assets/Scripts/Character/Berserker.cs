using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Global_Define;

public class Berserker : PlayableCharacter
{
    private CharacterState berserkerState;


    public CharacterState getBerserkerState
    {
        get { return berserkerState; }
    }

    public void SetBerserkerState(CharacterState _berserkerState)
    {
        berserkerState = _berserkerState;
    }

    void Update()
    {
        if (playingCharacter == false)
        {
            switch (berserkerState)
            {
                case CharacterState.Idle:
                    break;
                case CharacterState.Move:
                    break;
                case CharacterState.Run:
                    break;
                case CharacterState.Skill:
                    BerserkerStateSkill();
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

    private void BerserkerStateSkill()
    {
        //버서커의 스킬 인덱스 크기만큼 for문돌림
        //for(int  i=berserkerskillindex; i<berserkerSkillEndIndex;i++)
        //{
        //   몬스터리스트에있는 몬스터들을 모두 돌려봄
        //    for(int j=0;i<battleManager.Ins.monsterList.Count;i++
        //      {
        //          Character monster = battleManager.Ins.monsterList[j].GetComponent<Character>();
        //          SkillSelector(i,monster);
        //      }
        //+우리케릭터
        //        
    }
}
