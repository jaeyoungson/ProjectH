using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temp_Combo : MonoBehaviour
{

    Animator animator;

    private int curAnimation;   //애니메이션 결정
    private bool canNomalAttack;    //애니메이션 동안 입력불가

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        curAnimation = 0;   //공격 애니메이션 1번부터 0은 아무것도 안함
        canNomalAttack = true;  //일반공격키입력가능
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            NomalComboAttackStart();
        }
    }

    void NomalComboAttackStart()
    {
        if(canNomalAttack)
        {
            curAnimation++;
        }
        if(curAnimation == 1)
        {
            animator.SetInteger("", 1/*tempNumber*/);
        }
    }

    public void ComboCheck()
    {
        canNomalAttack = false;

        if(animator.GetCurrentAnimatorStateInfo(0).IsName("") && curAnimation == 1)
        {
            animator.SetInteger("", 1/*tempNumber*/);
            canNomalAttack = true;
            curAnimation = 0;
        }
        else if (animator.GetCurrentAnimatorStateInfo(0).IsName("") && curAnimation >= 2)
        {          
            animator.SetInteger("", 1/*tempNumber*/);
            canNomalAttack = true;
        }
        else if (animator.GetCurrentAnimatorStateInfo(0).IsName("") && curAnimation == 2)
        {           
            animator.SetInteger("", 1/*tempNumber*/);
            canNomalAttack = true;
            curAnimation = 0;
        }
        else if (animator.GetCurrentAnimatorStateInfo(0).IsName("") && curAnimation >= 3)
        {           
            animator.SetInteger("", 1/*tempNumber*/);
            canNomalAttack = true;
        }
        else if (animator.GetCurrentAnimatorStateInfo(0).IsName("") && curAnimation == 3)
        {
            animator.SetInteger("", 1/*tempNumber*/);
            canNomalAttack = true;
            curAnimation = 0;
        }
        else if (animator.GetCurrentAnimatorStateInfo(0).IsName("") && curAnimation >= 4)
        {
            animator.SetInteger("", 1/*tempNumber*/);
            canNomalAttack = true;
        }
        else if (animator.GetCurrentAnimatorStateInfo(0).IsName(""))
        {        
            animator.SetInteger("", 1/*tempNumber*/);
            canNomalAttack = true;
            curAnimation = 0;
        }
    }
}
