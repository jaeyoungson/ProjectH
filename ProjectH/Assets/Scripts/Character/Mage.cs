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
    public float normalSkillRange;

    public float normalReTime;
    public float cureWindReTime;

    public float normalComboTime;

    private Combo combo;
    private ReStiffen reStiffen =new ReStiffen() ;
    public GameObject ring;
    public GameObject rightHand;
    public GameObject leftHand;

    private void Awake()
    {
        combo = gameObject.AddComponent<Combo>();
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
                    //이펙트 가져오기
                    NormalCombo1();
                    reStiffen.SetReStiffenTime(normalReTime);
                    Debug.Log("normal1");
                    break;
                case 1:
                    if (combo.combo == true)
                    {
                        normalskillCombo++;
                        isNormalSkill = true;
                        NormalCombo2();
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
                    if (combo.combo == true)
                    {
                        //3연타 나가는 코드 만들기
                        StartCoroutine(ComboThird());
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

    public void NormalCombo1()
    {
        GameObject bolt=PoolManager.Ins.GetObject((int)ObjectPool.Projectile, (int)ProjectilePool.LightningBolt);
        Projectile boltProjectile = bolt.GetComponent<Projectile>();
        combo.SetSkillComboTime(normalComboTime);
        boltProjectile.SetDirection(gameObject.transform);
        bolt.SetActive(true);
    }

    public void NormalCombo2()
    {
        GameObject bolt = PoolManager.Ins.GetObject((int)ObjectPool.Projectile, (int)ProjectilePool.LightningBolt);
        Projectile boltProjectile = bolt.GetComponent<Projectile>();
        combo.SetSkillComboTime(normalComboTime);
        boltProjectile.SetDirection(gameObject.transform);
        bolt.SetActive(true);
    }

    public void NormalCombo3()
    {
        GameObject strike = PoolManager.Ins.GetObject((int)ObjectPool.Projectile, (int)ProjectilePool.LightningStrike);
        strike.transform.position = gameObject.transform.position + (Vector3.up * 0.5f)+(Vector3.forward*0.5f);
        combo.SetSkillComboTime(normalComboTime);
        strike.SetActive(true);       
    }

    IEnumerator ComboThird()
    {
        NormalCombo3();
        yield return new WaitForSeconds(0.1f);
        NormalCombo3();
        yield return new WaitForSeconds(0.2f);
        NormalCombo3();
    }

    public void NormalSkillEnd()
    {
        normalskillCombo = 0;
        isNormalSkill = false;
    }

    public override void SkillNumberOne()
    {
        //장판소환후에 체력회복
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
