using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour
{    

    public static void ActiveSkill(int index)
    {
        switch (index)
        {
            default:
                break;
            //인덱스에 따라서 스킬을 구현함
            //스킬쓰는 도중에 자신의 스테이트 변경
        }

    }

    public static void PassiveSkill(int index)
    {

    }
    public virtual void SkillImplementation() { }
}
