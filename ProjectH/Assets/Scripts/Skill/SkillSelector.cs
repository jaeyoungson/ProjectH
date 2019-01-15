using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Global_Define;
public class SkillSelector : MonoBehaviour
{
    Dictionary<int,Sheet1Info> table = Sheet1Table.GetAll();
    public void SkillSelect(int skillIndex,Character target)
    {

      if(Sheet1Table.GetByKey(skillIndex)!= null)
        {
            Sheet1Info tableInfo = table[skillIndex];
            if (tableInfo.m_targetObject_Type == (int)target.targetType)
            {
                CheckBehaviorPropertyOne(tableInfo,target);
            }
            else
            {
                return;
            }
        }
    }

    private void CheckBehaviorPropertyOne(Sheet1Info tableInfo,Character target)
    {
        switch (tableInfo.m_behaviorProperties1)
        {
            default:                
                break;
            case 1:
               
                break;
            case 2://부과효과
                TargetImposeEffect(tableInfo, target);
                break;
            case 3: 
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
        }
    }


    private void CheckBehaviorPropertyTwo(Sheet1Info tableInfo,Character target)
    {
        switch (tableInfo.m_behaviorProperties2)
        {
            default:
                break;
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
            case 3:                
                break;
            case 4://거리비교
                TargetCheckRange(tableInfo, target);
                break;
            case 5:
                break;
            case 6:
                break;
        }

    }

    #region targetCheck

    private void TargetImposeEffect(Sheet1Info tableInfo, Character target)
    {
        switch (tableInfo.m_behaviorCondition1)
        {
            default:
                break;
            case 0:
                break;
            case 1:

                break;
            case 2:

                break;
            case 3:

                break;
            case 4:

                break;
        }
    }
    private void TargetCheckRange(Sheet1Info tableInfo, Character target)
    {
       
        switch (tableInfo.m_behaviorCondition2)
        {
            case 0:
                if(tableInfo.m_value2 == target.targetRange)
                {
                    //Skill.ActiveSkill(스킬인덱스)
                }
                break;
            case 1:
                break;
            case 2:
                break;
            case 3:                
                break;
            case 4:
                break;
            case 5:
                break;
        }
    }
    #endregion
}
