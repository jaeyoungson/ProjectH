using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitonDistortion : Projectile
{
    public float range;
    private float curMoveRange;

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void ProjectileMove()
    {
        if(curMoveRange<range)
        {
            gameObject.transform.Translate(direction * moveSpeed * Time.deltaTime);
            curMoveRange += moveSpeed * Time.deltaTime;
        }
        else
        {
            curMoveRange = 0;
            gameObject.SetActive(false);
            //중력자탄 생성
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Monster"))
        {
            //중력자탄 생성
        }
    }


}
