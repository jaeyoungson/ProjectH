using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Global_Define;

public class Skill : MonoBehaviour
{
    public new string name;
    public int damage;
    public float coolTime;
    protected float curCoolTime;
    public bool availableSkill;

    public virtual void ActiveSkill()           {}
    public virtual void PassiveSkill()          {}
    public virtual void SkillImplementation()   {}
    public virtual void EndSkillAnimation()     {}
}
