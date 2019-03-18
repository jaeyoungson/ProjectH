using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Global_Define;

public class PlayableCharacter : Character
{
    public bool playingCharacter;   //true 플레이중 false nonplay
    public List<Character> monsterList;
    private CharacterState state =default;
    public Animator animator;
    public int exp;
    public int next_Exp;

    [SerializeField] float stateTurnSpeed = 180;
    [SerializeField] float movingTurnSpeed = 360;
    public bool moveCondition;
    float turnAmount;
    float forwardAmount;
    private new void Awake()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playingCharacter==false)
        {
            switch (state)
            {
                case CharacterState.Idle:
                    break;
                case CharacterState.Run:
                    break;
                case CharacterState.Move:
                    break;
                case CharacterState.Battle:   
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

        //float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");
        //Move(h, v);
    }
    #region protected virtual
    protected virtual void Idle() { }
    #endregion
    #region public virtual
    public virtual void NormalSkill()      { }
    public virtual void SkillNumberOne()   { }
    public virtual void SkillNumberTwo()   { }
    public virtual void SkillNumberThree() { }
    public virtual void EvasionSkill()     { }
    public virtual void UltimateSkill()    { }
    public virtual void CooperationSkill() { }
    #endregion
    #region Move
    public void Move(Vector3 move,float h,float v)
    {
        if(moveCondition ==true)
        {
            if (move.magnitude > 1.0f)
                move.Normalize();
            move = transform.InverseTransformDirection(move);

            turnAmount = Mathf.Atan2(move.x, move.z);
            forwardAmount = move.z;
            ApplyExtraTurnRotation();
            gameObject.transform.Translate(h * moveSpeed * Time.deltaTime, 0, v * moveSpeed * Time.deltaTime, Space.World);
            UpdateAnimatorMove(move);
        }        
    }

    private void UpdateAnimatorMove(Vector3 move)
    {
        animator.SetFloat("X", move.z);
        animator.SetFloat("Y",move.x);
    }

    void ApplyExtraTurnRotation()
    {
        float turnSpeed = Mathf.Lerp(stateTurnSpeed, movingTurnSpeed, forwardAmount);
        transform.Rotate(0, turnAmount * turnSpeed * Time.deltaTime, 0);
    }
    #endregion 
}
