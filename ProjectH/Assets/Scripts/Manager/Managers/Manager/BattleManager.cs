using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Global_Define;

public class BattleManager : ManagerBase<BattleManager>
{
    public GameObject[] playerCharacters = new GameObject[3];
    public GameObject curPlayCharacter;
    public PlayCharacter jobState;
    public List<GameObject> monsterList;//게임매니저에서 몬스터 생성해주면 몬스터리스트에 넣어줌
    public bool battleState; // 현재 싸움 상태인지 아닌지 체크 true 배틀 false 평화상태
    
    private new void Awake()
    {
        base.Awake();
        curPlayCharacter = playerCharacters[(int)PlayCharacter.Mage];
    }

    public void ChangeCharacterJob(PlayCharacter nextPlaycharacter)
    {
        if((int)nextPlaycharacter<3)
        {
            curPlayCharacter = playerCharacters[(int)nextPlaycharacter];
            InputManager.Ins.playGameObject = curPlayCharacter;
            InputManager.Ins.curPlayCharacter = InputManager.Ins.playGameObject.GetComponent<PlayableCharacter>();
        }
    }
}
