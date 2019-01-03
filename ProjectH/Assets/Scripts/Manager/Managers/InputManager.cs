using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : ManagerBase<InputManager>
{
    public Character playGameObject;

    // 키코드 변수 목록
    #region KeyCode
    private KeyCode forward;//default W
    private KeyCode backward;//default S
    private KeyCode left;//default A
    private KeyCode right;//default D

    private KeyCode characterChange;//dafault Quote(`)



    #endregion

    private new void Awake()
    {
        //키코드 변수에 PlayerPrefs에 있는 커스텀된 string 값을 가져와서 그 코드로변경 없다면 디폴트 값으로 가져옴
        forward = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("forward", "W"));
        backward = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("backward", "S"));
        left = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("left", "A"));
        right = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("right", "D"));
        characterChange = (KeyCode)System.Enum.Parse((typeof(KeyCode)), PlayerPrefs.GetString("characterChange", "Quote"));
    }

    private void Start()
    {
        playGameObject = BattleManager.Ins.playingCharacter.GetComponent<Character>();
      
    }
    

    void Update()
    {
        #region move
        if(Input.GetKey(forward))
        {
            ForwardMove();
        }

        if(Input.GetKey(backward))
        {
            BackwardMove();
        }

        if(Input.GetKey(left))
        {
            LeftMove();
        }

        if(Input.GetKey(right))
        {
            RightMove();
        }

        #endregion
        if (Input.GetKeyDown(characterChange))
        {
            GameManager.Ins.ChangeCharacterJob();
        }
       


    }
    #region movefuction
    private void ForwardMove()
    {
        playGameObject.transform.Translate(Vector3.forward*playGameObject.moveSpeed*Time.deltaTime);
    }

    private void BackwardMove()
    {
        playGameObject.transform.Translate(Vector3.back * playGameObject.moveSpeed * Time.deltaTime);
    }

    private void LeftMove()
    {
        playGameObject.transform.Translate(Vector3.left * playGameObject.moveSpeed * Time.deltaTime);
    }

    private void RightMove()
    {
        playGameObject.transform.Translate(Vector3.right * playGameObject.moveSpeed * Time.deltaTime);
    }
    #endregion
}
