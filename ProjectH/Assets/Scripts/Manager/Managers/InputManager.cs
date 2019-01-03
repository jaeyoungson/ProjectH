using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : ManagerBase<InputManager>
{
    public Character playGameObject;


    private new void Awake()
    {

    }

    private void Start()
    {
        playGameObject = BattleManager.Ins.playingCharacter.GetComponent<Character>();
      
    }
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Vertical")||Input.GetButton("Horizontal"))
        {
            Move();
        }
        
    }

    private void Move()
    {

        float translationZ = Input.GetAxis("Vertical") * playGameObject.moveSpeed;
        float translationX = Input.GetAxis("Horizontal") * playGameObject.moveSpeed;

        translationX *= Time.deltaTime;
        translationZ *= Time.deltaTime;

        playGameObject.transform.Translate(translationX, playGameObject.transform.position.y, translationZ);
    }
}
