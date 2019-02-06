using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Global_Define;

public class CureWind : Skill
{
    private void Update()
    {
        if(!availableSkill)
        {
            if(curCoolTime<coolTime)
            {
                curCoolTime += Time.deltaTime;
            }
            else
            {
                curCoolTime = 0;
                availableSkill = true;
            }
        }
    }
    public override void ActiveSkill()
    {
        if (availableSkill)
        {
            availableSkill = false;
            GameObject cureWind = PoolManager.Ins.GetObject((int)ObjectPool.Projectile, (int)ProjectilePool.CureWind);
            cureWind.transform.position = gameObject.transform.position;
            cureWind.SetActive(true);
        }
        else
        {
            Debug.Log("curewind coolTime");
        }
     
    }

}
    