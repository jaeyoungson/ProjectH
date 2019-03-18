using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Global_Define;

public class Mage : PlayableCharacter
{
    public MageState mageState;

    public float normalReTime;
    public float cureWindReTime;
    public float ringRotateSpeed;

    public Transform rightHand;

    public Combo combo;
    public ReStiffen reStiffen =new ReStiffen();
    public GameObject ring;
    public MageNormalSkill mageNormalSkill;
    public CureWind cureWind;
    
    private new void Awake()
    {
        combo = gameObject.AddComponent<Combo>();
        animator = gameObject.GetComponent<Animator>();
        moveCondition = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (playingCharacter == false)
        {
            switch (mageState)
            {
                default:
                    break;
            }
        }
        reStiffen.ReStiffenCheck();
    }

    public override void NormalSkill()
    {
        if (!reStiffen.reStiffen)
            mageNormalSkill.ActiveSkill();
    }

    public override void SkillNumberOne()
    {
        //name: CureWind
        cureWind.ActiveSkill();
    }

    public override void SkillNumberTwo()
    {
        //구체를 몬스터를 향해 발사후에 4미터 크기의 구체형 히트박스 생성
        //dmgInterval간격으로 빨아드린다
       //duration은 지속시간
    }

    public override void SkillNumberThree()
    {
        //케릭터 위치기준으로 정면을 향해 4미터 날아가는 히트박스 사출
        //히트박스에 닿은 최초 대상을 포함하여 최초 접촉한 가까운 3마리적에게 전이
        //전이가능한 대상이 없을경우 3회 피해
    }

    public override void EvasionSkill()
    {
        //물어볼것
    }

    public override void CooperationSkill()
    {
        //대상이 방어력 감소일때 연타12
        //물어볼것
    }
    public override void UltimateSkill()
    {
        //관련 장판 소환함 ㅇㅇ 끝
    }
}
