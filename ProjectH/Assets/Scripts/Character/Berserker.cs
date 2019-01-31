using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Global_Define;

[System.Serializable]
public class PlayerAnim
{
    public AnimationClip born;
    public AnimationClip idle;
    public AnimationClip walk;
    public AnimationClip attack1;
    public AnimationClip attack2;
    public AnimationClip attack3;
}

public class Berserker : PlayableCharacter
{

    #region
    private float h = 0.0f;
    private float v = 0.0f;
    private float r = 0.0f;

    private Transform tr;

    public PlayerAnim playerAnim;

    [HideInInspector]
    public Animation anim;
    #endregion

    void Start()
    {
        tr = GetComponent<Transform>();
        anim = GetComponent<Animation>();
        anim.clip = playerAnim.born;
        anim.Play();
    }

    private CharacterState berserkerState;


    public CharacterState getBerserkerState
    {
        get { return berserkerState; }
    }

    public void SetBerserkerState(CharacterState _berserkerState)
    {
        berserkerState = _berserkerState;
    }

    void Update()
    {
        if (playingCharacter == false)
        {
            switch (berserkerState)
            {
                case CharacterState.Idle:
                    break;
                case CharacterState.Move:
                    break;
                case CharacterState.Run:
                    break;
                case CharacterState.Battle:
                    BerserkerStateSkill();
                    break;
                case CharacterState.Stiffen:
                    break;
                case CharacterState.Down:
                    break;
                case CharacterState.WakeUp:
                    break;
                case CharacterState.Recovery:
                    break;
                default:
                    break;
            }
        }

        #region
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        r = Input.GetAxis("Mouse X");

        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);
        tr.Translate(moveDir.normalized * moveSpeed * Time.deltaTime, Space.Self);

        tr.Rotate(Vector3.up * moveSpeed * Time.deltaTime * r);

        if(v >= 0.1f)
        {
            anim.CrossFade(playerAnim.walk.name, 0.3f);
        }
        else if(v <= -0.1f)
        {
            anim.CrossFade(playerAnim.walk.name, 0.3f);
        }
        else if(h <= -0.1f)
        {
            anim.CrossFade(playerAnim.walk.name, 0.3f);
        }
        else
        {
            anim.CrossFade(playerAnim.idle.name, 0.3f);
        }

        #endregion
    }

    private void BerserkerStateSkill()
    {
        //버서커의 스킬 인덱스 크기만큼 for문돌림
        //for(int  i=berserkerskillindex; i<berserkerSkillEndIndex;i++)
        //{
        //   몬스터리스트에있는 몬스터들을 모두 돌려봄
        //    for(int j=0;i<battleManager.Ins.monsterList.Count;i++
        //      {
        //          Character monster = battleManager.Ins.monsterList[j].GetComponent<Character>();
        //          SkillSelector(i,monster);
        //      }
        //+우리케릭터
        //        
    }

    public override void NormalSkill()
    {

        //평타구현

        base.NormalSkill();
    }
}
