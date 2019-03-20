using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int damage { get; private set; }
    public float moveSpeed;
    protected Vector3 direction;
    public void SetDamage()
    {

    }

    private void Update()
    {
        ProjectileMove();
    }

    protected virtual void ProjectileMove()   {}//투사체마다 다른 구현이 있을 수도있어 구현은 상속받아 하기

    //setactive true후에 방향을 정해줄것
    public virtual void SetDirection(Transform characterForward)
    {
        direction = characterForward.forward;
        //gameObject.transform.position = characterForward.position;
    }

}
