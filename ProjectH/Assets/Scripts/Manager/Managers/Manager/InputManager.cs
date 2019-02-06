using UnityEngine;
using Global_Define;
public class InputManager : ManagerBase<InputManager>
{
    public GameObject playGameObject;
    public PlayableCharacter curPlayCharacter;

    // 키코드 변수 목록
    #region KeyCode
    private KeyCode forward;//default W
    private KeyCode backward;//default S
    private KeyCode left;//default A
    private KeyCode right;//default D
    private KeyCode run;//default LeftShift

    private KeyCode berserker;//default F1
    private KeyCode mage;//default F2
    private KeyCode archer;//default F3

    private KeyCode skillNumber1;//default 1
    private KeyCode skillNumber2;//default 2
    private KeyCode skillNumber3;//default 3
    private KeyCode cooperationSkill;//default BackQuote(`)
    private KeyCode ultimateSkill;//default V
    private KeyCode evasionSkill;//default Space
    public KeyCode normalAttack;//default Mouse0(mouse leftClick)

    private KeyCode equip;//default p
    private KeyCode inventory;//default Tab
    private KeyCode map;//default M
    #endregion

    private float turnMouse_X = 0.0f;
    public float X_axisRotateSpeed = 100.0f;

    private void Awake()
    {
        base.Awake();
        //키코드 변수에 PlayerPrefs에 있는 커스텀된 string 값을 가져와서 그 코드로변경 없다면 디폴트 값으로 가져옴
        #region moveKey
        forward = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("forward", "W"));
        backward = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("backward", "S"));
        left = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("left", "A"));
        right = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("right", "D"));
        run = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("run", "LeftShift"));
        #endregion

        #region Character Change
        berserker = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("berserker", "F1"));
        mage = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("mage", "F2"));
        archer = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("archer", "F3"));
        #endregion

        #region skill
        normalAttack = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("normalAttack", "Mouse0"));
        skillNumber1 = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("skillNumber1", "Alpha1"));
        skillNumber2 = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("skillNumber2", "Alpha2"));
        skillNumber3 = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("skillNumber3", "Alpha3"));
        cooperationSkill = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("cooperationSkill", "BackQuote"));
        ultimateSkill = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("ultimateSkill", "V"));
        evasionSkill = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("evasionSkill", "Space"));
        #endregion

        #region util
        equip = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("equip", "P"));
        inventory = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("inventory", "Tab"));
        map = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("map", "M"));
        #endregion
    }

    private void Start()
    {
        playGameObject = BattleManager.Ins.curPlayCharacter;
        curPlayCharacter = BattleManager.Ins.curPlayCharacter.GetComponent<PlayableCharacter>();
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

        if(Input.GetKeyDown(run))
        {
            Run();
        }

        #endregion
        #region CharacterChange
        if(Input.GetKeyDown(berserker))
        {
            BerserkerChange();
        }
        if(Input.GetKeyDown(mage))
        {
            MageChange();
        }

        if(Input.GetKeyDown(archer))
        {
            ArcherChange();
        }
        #endregion
        #region Skill

        if (Input.GetKeyDown(skillNumber1))
        {
            SkillNumberOne();
        }



        if(Input.GetKeyDown(skillNumber2))
        {
            SkillNumberTwo();
        }

        if(Input.GetKeyDown(skillNumber3))
        {
            SkillNumberThree();
        }

        if(Input.GetKeyDown(cooperationSkill))
        {
            CooperationSkill();
        }

        if(Input.GetKeyDown(ultimateSkill))
        {
            UltimateSkill();
        }

        if(Input.GetKeyDown(evasionSkill))
        {
            EvastionSkill();
        }
        
        if(Input.GetKeyDown(normalAttack))
        {
            NormalSkill();
        }

        if(Input.GetKeyUp(normalAttack))
        {
            Character character = BattleManager.Ins.curPlayCharacter.GetComponent<Character>();
            if (character.playCharacter == PlayCharacter.Archer)
            {
                NormalSkill();
            }
        }
        #endregion
        #region utilkey
        if (Input.GetKeyDown(equip))
        {
            EquipOpen();
        }

        if(Input.GetKeyDown(inventory))
        {
            InventoryOpen();
        }

        if(Input.GetKeyDown(map))
        {
            MapOpen();
        }
        #endregion
        TurnMouse();

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

    private void Run()
    {
        Debug.Log("run");
    }

    private void TurnMouse()
    {
        turnMouse_X = Input.GetAxis("Mouse X");
        playGameObject.transform.Rotate(Vector3.up, X_axisRotateSpeed * Time.deltaTime * turnMouse_X);
    }
    #endregion

    #region CharacterChange
    private void BerserkerChange()
    {
        #if UNITY_EDITOR
            Debug.Log("Berserker Change");
        #endif
        BattleManager.Ins.ChangeCharacterJob(PlayCharacter.Berserker);
    }

    private void MageChange()
    {
        #if UNITY_EDITOR
            Debug.Log("Mage Change");
        #endif
        BattleManager.Ins.ChangeCharacterJob(PlayCharacter.Mage);
    }

    private void ArcherChange()
    {
        #if UNITY_EDITOR
            Debug.Log("ArcherChange");
        #endif
        BattleManager.Ins.ChangeCharacterJob(PlayCharacter.Archer);
    }
    #endregion

    #region Skill Fuction
    private void NormalSkill()
    {
        BattleManager.Ins.curPlayCharacter.GetComponent<PlayableCharacter>().NormalSkill();
    }
    private void SkillNumberOne()
    {
        BattleManager.Ins.curPlayCharacter.GetComponent<PlayableCharacter>().SkillNumberOne();
    }

    private void SkillNumberTwo()
    {
        Debug.Log("SkillNumberTwo");
    }

    private void SkillNumberThree()
    {
        Debug.Log("SkillNumberThree");
    }

    private void CooperationSkill()
    {
        Debug.Log("CooperationSkill");
    }

    private void UltimateSkill()
    {
        Debug.Log("UltimateSkill");
    }

    private void EvastionSkill()
    {
        Debug.Log("EvastionSkill");
    }
    #endregion

    #region Utilfuction
    private void EquipOpen()
    {
        Debug.Log("EquipOpen");
    }

    private void InventoryOpen()
    {
        Debug.Log("Inventory Open");
    }

    private void MapOpen()
    {
        Debug.Log("Map Open");
    }
    #endregion

}
