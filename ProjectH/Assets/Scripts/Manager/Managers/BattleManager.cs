using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Global_Define;

public class BattleManager : ManagerBase<BattleManager>
{
    public GameObject[] playerCharacters = new GameObject[3];
    public GameObject curPlayCharacter;
    public PlayCharacter jobState;
    public bool battleState; // 현재 싸움 상태인지 아닌지 체크 true 배틀 false 평화상태

    private new void Awake()
    {
        curPlayCharacter = playerCharacters[(int)PlayCharacter.Warrior];
    }

    public void ChangeCharacterJob()
    {
        if ((int)jobState < 2)
        {
            jobState++;
            curPlayCharacter = playerCharacters[(int)jobState];
        }
        else
        {
            curPlayCharacter = playerCharacters[(int)PlayCharacter.Warrior];
            jobState = PlayCharacter.Warrior;
        }
    }
}
