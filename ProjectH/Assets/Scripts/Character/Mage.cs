using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Global_Define;

public class Mage : PlayableCharacter
{
    public MageState mageState;

    private int normalskillCombo=0;
    private bool isNormalSkill;

    public float ringRotateSpeed;

    public float normalReTime;
    public float cureWindReTime;

    private ReStiffen reStiffen =new ReStiffen() ;
    public GameObject ring;

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
        AroundRing();
        reStiffen.ReStiffenCheck();
    }

    public void AroundRing()
    {
        ring.transform.Rotate(Vector3.up, ringRotateSpeed * Time.deltaTime,Space.World);
    }

    public override void NormalSkill()
    {
        if(!reStiffen.reStiffen)
        {
            switch (normalskillCombo)
            {
                case 0:
                    normalskillCombo++;
                    isNormalSkill = true;
                    //이펙트 가져오기
                    reStiffen.SetReStiffenTime(normalReTime);
                    Debug.Log("normal1");
                    break;
                case 1:
                    if (isNormalSkill == true)
                    {
                        normalskillCombo++;
                        isNormalSkill = true;
                        reStiffen.SetReStiffenTime(normalReTime);
                        Debug.Log("normal2");
                    }
                    else
                    {
                        normalskillCombo = 0;
                        isNormalSkill = false;
                        NormalSkill();
                    }
                    break;
                case 2:
                    if (isNormalSkill == true)
                    {
                        //3연타 나가는 코드 만들기
                        Debug.Log("normal3");
                        reStiffen.SetReStiffenTime(normalReTime);
                        NormalSkillEnd();
                    }
                    else
                    {
                        normalskillCombo = 0;
                        isNormalSkill = false;
                        NormalSkill();
                    }
                    break;
            }
        }       
    }

    public void NormalSkillEnd()
    {
        normalskillCombo = 0;
        isNormalSkill = false;
    }

    public override void UltimateSkill()
    {
        //관련 장판 소환함 ㅇㅇ 끝
    }
}
