using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Global_Define;

public class Berserker : PlayableCharacter
{

    #region
    private Transform tr;

    [HideInInspector]
    public Animation anim;
    #endregion
    private new void Awake()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    void Start()
    {

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

    public override void NormalSkill()
    {

        //평타구현

        base.NormalSkill();
    }
}
