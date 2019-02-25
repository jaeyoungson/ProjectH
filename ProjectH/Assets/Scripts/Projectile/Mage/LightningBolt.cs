using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningBolt : Projectile
{
    public float range;
    private float curMoveRange;

    protected override void ProjectileMove()
    {
        if(curMoveRange<range) //사거리check
        {
            gameObject.transform.Translate(direction * moveSpeed * Time.deltaTime);
            curMoveRange += moveSpeed * Time.deltaTime; 
        }
        else
        {
            curMoveRange = 0;
            gameObject.SetActive(false);
        }
    }

}
