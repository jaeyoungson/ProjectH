using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Global_Define;
using System;

public class MageNormalSkill : Skill
{
    public int normalskillCombo = 0;
    private Mage mage;
    private bool isNormalSkill;

    public float normalComboTime;
    public float normalSkillRange;
    public float normalReTime;
    
    private void Awake()
    {
        mage = BattleManager.Ins.playerCharacters[(int)PlayCharacter.Mage].GetComponent<Mage>();
    }

    public override void ActiveSkill()
    {
        
        if(normalskillCombo ==0)
        {
            mage.moveCondition = false;
            mage.animator.SetBool("Attack2", true);
        }
        else
        {
            mage.animator.SetBool("Locomotion", true);
            mage.animator.SetBool("Attack2", true);
        }
          
        
    }

    private void NormalSkill()
    {
        switch (normalskillCombo)
        {
            case 0:
                normalskillCombo++;
                NormalCombo1();
                mage.reStiffen.SetReStiffenTime(normalReTime);
                Debug.Log("normal1");
                break;
            case 1:
                if (mage.combo.combo == true)
                {
                    normalskillCombo++;
                    isNormalSkill = true;
                    NormalCombo2();
                    mage.reStiffen.SetReStiffenTime(normalReTime);
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
                if (mage.combo.combo == true)
                {
                    //3연타 나가는 코드 만들기
                    StartCoroutine(ComboThird());
                    Debug.Log("normal3");
                    mage.reStiffen.SetReStiffenTime(normalReTime);
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

    private void NormalCombo1()
    {
        GameObject bolt = PoolManager.Ins.GetObject((int)ObjectPool.Projectile, (int)ProjectilePool.LightningBolt);
        Projectile boltProjectile = bolt.GetComponent<Projectile>();
        bolt.transform.position = gameObject.GetComponent<Mage>().rightHand.position;
        mage.combo.SetSkillComboTime(normalComboTime);
        boltProjectile.SetDirection(gameObject.transform);
        bolt.SetActive(true);
    }

    private void NormalCombo2()
    {
        GameObject bolt = PoolManager.Ins.GetObject((int)ObjectPool.Projectile, (int)ProjectilePool.LightningBolt);
        Projectile boltProjectile = bolt.GetComponent<Projectile>();
        bolt.transform.position = gameObject.GetComponent<Mage>().rightHand.position;
        mage.combo.SetSkillComboTime(normalComboTime);
        boltProjectile.SetDirection(gameObject.transform);
        bolt.SetActive(true);
    }

    private void NormalCombo3()
    {
        GameObject strike = PoolManager.Ins.GetObject((int)ObjectPool.Projectile, (int)ProjectilePool.LightningStrike);
        strike.transform.position = gameObject.GetComponent<Mage>().rightHand.position;
        strike.transform.rotation = gameObject.transform.rotation;
        mage.combo.SetSkillComboTime(normalComboTime);
        strike.SetActive(true);
    }

    IEnumerator ComboThird()
    {
        NormalCombo3();
        yield return new WaitForSeconds(0.2f);
        NormalCombo3();
        yield return new WaitForSeconds(0.3f);
        NormalCombo3();
    }
    private void NormalSkillEnd()
    {
        normalskillCombo = 0;
        isNormalSkill = false;
    }

    public override void EndSkillAnimation()
    {
        mage.animator.SetBool("Locomotion", true);
        mage.moveCondition = true;
    }
}
