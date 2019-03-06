using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Global_Define;

public class PlayableCharacter : Character
{
    public bool playingCharacter;   //true 플레이중 false nonplay
    public List<Character> monsterList;
    private CharacterState state =default;
    protected Animator animator;
    public int exp;
    public int next_Exp;

    [SerializeField] float stateTurnSpeed = 180;
    [SerializeField] float movingTurnSpeed = 360;
    float turnAmount;
    float forwardAmount;
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

    //public void Move(float h,float v)
    //{
    //    gameObject.transform.Translate(new Vector3(h, 0, v)*moveSpeed*Time.deltaTime);

    //    animator.SetFloat("X",-h);
    //    animator.SetFloat("Y",v);

    //}

    //public void ForwardMove()
    //{
    //    if (!animator.GetCurrentAnimatorStateInfo(0).IsName("AS_forward"))
    //    {
    //        animator.SetBool("Forward", true);
    //    }
    //    gameObject.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    //    //gameObject.transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(Camera.main.transform.forward, gameObject.transform.up), 250.0f * Time.deltaTime);


    //}

    //public void BackWardMove()
    //{
    //    if (!animator.GetCurrentAnimatorStateInfo(0).IsName("AS_backward"))
    //    {
    //        animator.SetBool("Backward", true);
    //    }
    //    gameObject.transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
    //}

    //public void LeftMove()
    //{
    //    gameObject.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    //    gameObject.transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(-Camera.main.transform.right, gameObject.transform.up), 250.0f * Time.deltaTime);

    //    //gameObject.transform.Rotate(new Vector3(0, -90, 0));
    //}

    //public void LeftMoveStop()
    //{
    //    gameObject.transform.LookAt(Camera.main.transform.forward);
    //}

    //public void RightMove()
    //{

    //}

    public void Move(Vector3 move,float h,float v)
    {
        if (move.magnitude > 1.0f)
            move.Normalize();
        move = transform.InverseTransformDirection(move);

        turnAmount = Mathf.Atan2(move.x, move.z);
        forwardAmount = move.z;
        
        gameObject.transform.Translate(h* moveSpeed * Time.deltaTime,0,Mathf.Abs(v)*moveSpeed*Time.deltaTime);
        ApplyExtraTurnRotation();
        UpdateAnimator(move);
        
    }

    private void UpdateAnimator(Vector3 move)
    {
        
    }

    void ApplyExtraTurnRotation()
    {
        float turnSpeed = Mathf.Lerp(stateTurnSpeed, movingTurnSpeed, forwardAmount);
        transform.Rotate(0, turnAmount * turnSpeed * Time.deltaTime, 0);
    }
    #endregion 
}
