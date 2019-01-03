using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : ManagerBase<InputManager>
{
    public GameObject playGameObject;
    private Character curPlayCharacter;

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
        characterChange = (KeyCode)System.Enum.Parse((typeof(KeyCode)), PlayerPrefs.GetString("characterChange", "Tab"));
    }

    private void Start()
    {
        playGameObject = GameManager.Ins.curPlayCharacter;
        curPlayCharacter = GameManager.Ins.curPlayCharacter.GetComponent<Character>();
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
            playGameObject = GameManager.Ins.curPlayCharacter;
        }
       


    }
    #region movefuction
    private void ForwardMove()
    {
        playGameObject.transform.Translate(Vector3.forward* curPlayCharacter.moveSpeed*Time.deltaTime);
    }

    private void BackwardMove()
    {
        playGameObject.transform.Translate(Vector3.back * curPlayCharacter.moveSpeed * Time.deltaTime);
    }

    private void LeftMove()
    {
        playGameObject.transform.Translate(Vector3.left * curPlayCharacter.moveSpeed * Time.deltaTime);
    }

    private void RightMove()
    {
        playGameObject.transform.Translate(Vector3.right * curPlayCharacter.moveSpeed * Time.deltaTime);
    }
    #endregion
}
