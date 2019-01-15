using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Global_Define;

public class Character : MonoBehaviour
{
    public float moveSpeed;
    public PlayCharacter playCharacter;
    public CharacterTargetType targetType;
    public float targetRange;
    public Dictionary<AbnormalConditionState, AbnormalCondition> conditions;
    
    protected int hp;
    public int addHp;
    protected int sp;
    public int addSp;
    protected int atk;
    public int addAtk;
    protected int def;
    public int addDef;

    protected void Awake()
    {
        
    }

    #region get

    //index로 condition클래스를 가져다줌
    public AbnormalCondition GetConditionToIndex(int conditionIndex)
    {
        if(conditions.ContainsKey((AbnormalConditionState)conditionIndex))
        {
            return conditions[(AbnormalConditionState)conditionIndex];
        }
        else
        {
        #if UNITY_EDITOR
            Debug.Log("have not conditionIndex");
        #endif
        }
        return default;
    }
    protected void SettingCondition()
    {

    }
    #endregion

#region set

#endregion
} 
