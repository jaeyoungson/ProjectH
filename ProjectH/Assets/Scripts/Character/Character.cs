using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Global_Define;
using System;

public class Character : MonoBehaviour
{
    public float moveSpeed;
    public PlayCharacter playCharacter;
    public CharacterTargetType targetType;
    public float targetRange;
    public Dictionary<AbnormalConditionState, AbnormalCondition> conditions = new Dictionary<AbnormalConditionState, AbnormalCondition>();
    
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
        SettingCondition();
    }


    #region get

    //index로 condition클래스를 가져다줌
    public AbnormalCondition GetConditionToIndex(int conditionIndex)
    {
        AbnormalCondition temp = new AbnormalCondition();
        if(conditions.ContainsKey((AbnormalConditionState)conditionIndex))
        {
            temp = conditions[(AbnormalConditionState)conditionIndex];
        }
        else
        {
        #if UNITY_EDITOR
            Debug.Log("have not conditionIndex");
        #endif
        }
        return temp;
    }
    //string으로 condition클래스를 가져다줌
    public AbnormalCondition GetConditionToString(string conditionName)
    {
        AbnormalCondition temp = new AbnormalCondition();
        if (conditions.ContainsKey((AbnormalConditionState)System.Enum.Parse(typeof(AbnormalConditionState),conditionName)))
        {
            temp= conditions[(AbnormalConditionState)System.Enum.Parse(typeof(AbnormalConditionState), conditionName)];
        }
        else
        {
        #if UNITY_EDITOR
            Debug.Log("have not conditionString");
        #endif
        }
        return temp;
    }
    #endregion
    protected void SettingCondition()
    {
        var index = System.Enum.GetNames(typeof(AbnormalConditionState));
        foreach (var state in index)
        {
            AbnormalConditionState conditionName = (AbnormalConditionState)System.Enum.Parse(typeof(AbnormalConditionState), state);
            AbnormalCondition condition = new AbnormalCondition(conditionName);
            conditions.Add(conditionName, condition);
        }
    }
    #region set

    #endregion
} 
