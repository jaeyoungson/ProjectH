using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Global_Define;

public class EnemyInfo
{
    public string m_ID { get; private set; }
    public string m_Name { get; private set; }
    public int m_BaseHealth { get; private set; }
    public int m_PlayerHealth { get; private set; }
    public int m_BaseDefense { get; private set; }

    public void SetID(string ID) { m_ID = ID; }
    public void SetName(string Name) { m_Name = Name; }
    public void SetBaseHealth(int BaseHealth) { m_BaseHealth = BaseHealth; }
    public void SetPlayerHealth(int PlayerHealth) { m_PlayerHealth = PlayerHealth; }
    public void SetBaseDefense(int BaseDefense) { m_BaseDefense = BaseDefense; }
}

public class ItemInfo
{
    public int m_ID { get; private set; }
    public float m_AddHealth { get; private set; }
    public float m_AddAttack { get; private set; }
    public float m_AddDefense { get; private set; }
    public string m_Name { get; private set; }

    public void SetID(int ID) { m_ID = ID; }
    public void SetAddHealth(float AddHealth) { m_AddHealth = AddHealth; }
    public void SetAddAttack(float AddAttack) { m_AddAttack = AddAttack; }
    public void SetAddDefense(float AddDefense) { m_AddDefense = AddDefense; }
    public void SetName(string Name) { m_Name = Name; }
}

public class CharacterBehaviorInfo
{
    public int index { get; private set; }
    public string name { get; private set; }
    public int targetObject_Type { get; private set; }
    public int behaviorProperties1 { get; private set; }
    public int behaviorProperties2 { get; private set; }
    public int value1 { get; private set; }
    public int value2 { get; private set; }
    public int behaviorCondition1 { get; private set;}
    public int behaviorCondition2 { get; private set; }
    public int behaviorType { get; private set; }
    public float behaviorRate { get; private set; }

    public void SetIndex(int a_index)                            { index = a_index; }
    public void SetName(string a_name) { name = a_name; }
    public void SetTargetObject_Type(int a_targetObject_Type)    { targetObject_Type = a_targetObject_Type; }
    public void SetBehaviorProperties1(int a_behaviorPropertie1) { behaviorProperties1 = a_behaviorPropertie1; }
    public void SetBehaviorProperties2(int a_behaviorPropertie2) { behaviorProperties2 = a_behaviorPropertie2; }
    public void SetValue1(int a_value1)                          { value1 = a_value1; }
    public void SetValue2(int a_value2)                          { value2 = a_value2; }
    public void SetBehaviorCondition1(int a_behaviorCondition1)  { behaviorCondition1 = a_behaviorCondition1; }
    public void SetBehaviorCondition2(int a_behaviorCondition2)  { behaviorCondition2 = a_behaviorCondition2; }
    public void SetBehaviorType(int a_behaviorType)              { behaviorType = a_behaviorType; }
    public void SetBehaviorRate(float a_behaviorRate)              { behaviorRate = a_behaviorRate; }
}



public class LevelInfo
{
    public int m_ID { get; private set; }
    public float m_AddHealth { get; private set; }
    public float m_AddAttack { get; private set; }
    public float m_AddDefense { get; private set; }

    public void SetID(int ID) { m_ID = ID; }
    public void SetAddHealth(float AddHealth) { m_AddHealth = AddHealth; }
    public void SetAddAttack(float AddAttack) { m_AddAttack = AddAttack; }
    public void SetAddDefense(float AddDefense) { m_AddDefense = AddDefense; }
}

public class PlayerInfo
{
    public int m_ID { get; private set; }
    public string m_Name { get; private set; }
    public int m_BaseHealth { get; private set; }
    public int m_BaseAttack { get; private set; }
    public int m_BaseDefense { get; private set; }

    public void SetID(int ID) { m_ID = ID; }
    public void SetName(string Name) { m_Name = Name; }
    public void SetBaseHealth(int BaseHealth) { m_BaseHealth = BaseHealth; }
    public void SetBaseAttack(int BaseAttack) { m_BaseAttack = BaseAttack; }
    public void SetBaseDefense(int BaseDefense) { m_BaseDefense = BaseDefense; }
}

public class CharacterBehaviorInfoTable
{
    private static Dictionary<int, CharacterBehaviorInfo> Table = new Dictionary<int, CharacterBehaviorInfo>();
    public static Dictionary<int , CharacterBehaviorInfo> GetAll()
    {
        return Table;
    }
    public static CharacterBehaviorInfo GetByKey(int key)
    {
        CharacterBehaviorInfo value;
        if(Table.TryGetValue(key,out value))        
            return value;

        return null;       
    }
    public static CharacterBehaviorInfo GetByIndex(int index)
    {
        return Table.Values.ElementAt(index);
    }
    public static List<CharacterBehaviorInfo> GetAllList()
    {
        return Table.Values.ToList<CharacterBehaviorInfo>();
    }

    public CharacterBehaviorInfoTable()
    {
        InitTable();
    }
    
    private void InitTable()
    {
        TextAsset textAsset = Resources.Load("Tables/CharacterBehaviorInfo") as TextAsset;
        MemoryStream memoryStream = new MemoryStream(textAsset.bytes);
        BinaryReader binaryReader = new BinaryReader(memoryStream);

        int tableCount = binaryReader.ReadInt32();

        for (int i = 0; i < tableCount; ++i)
        {
            int key = binaryReader.ReadInt32();
            CharacterBehaviorInfo info = new CharacterBehaviorInfo();
            info.SetIndex(binaryReader.ReadInt32());
            info.SetName(binaryReader.ReadString());
            info.SetTargetObject_Type(binaryReader.ReadInt32());
            info.SetBehaviorProperties1(binaryReader.ReadInt32());
            info.SetBehaviorProperties2(binaryReader.ReadInt32());
            info.SetValue1(binaryReader.ReadInt32());
            info.SetValue2(binaryReader.ReadInt32());
            info.SetBehaviorCondition1(binaryReader.ReadInt32());
            info.SetBehaviorCondition2(binaryReader.ReadInt32());
            info.SetBehaviorType(binaryReader.ReadInt32());
            info.SetBehaviorRate(binaryReader.ReadSingle());
            Table.Add(key, info);
        }

    }
}

public class EnemyTable
{
    private static Dictionary<string, EnemyInfo> Table = new Dictionary<string, EnemyInfo>();

    public static Dictionary<string, EnemyInfo> GetAll()
    {
        return Table;
    }

    public static EnemyInfo GetByKey(string key)
    {
        EnemyInfo value;

        if (Table.TryGetValue(key, out value))
            return value;

        return null;
    }

    public static EnemyInfo GetByIndex(int index)
    {
        return Table.Values.ElementAt(index);
    }

    public static List<EnemyInfo> GetAllList()
    {
        return Table.Values.ToList();
    }

    public EnemyTable()
    {
        InitTable();
    }

    private void InitTable()
    {
        TextAsset textAsset = Resources.Load("Tables/Enemy") as TextAsset;
        MemoryStream memoryStream = new MemoryStream(textAsset.bytes);
        BinaryReader binaryReader = new BinaryReader(memoryStream);

        int tableCount = binaryReader.ReadInt32();

        for( int i = 0; i < tableCount; ++i)
        {
            string key = binaryReader.ReadString();

            EnemyInfo info = new EnemyInfo();
            info.SetID(binaryReader.ReadString());
            info.SetName(binaryReader.ReadString());
            info.SetBaseHealth(binaryReader.ReadInt32());
            info.SetPlayerHealth(binaryReader.ReadInt32());
            info.SetBaseDefense(binaryReader.ReadInt32());

            Table.Add(key, info);
        }
    }
}

public class ItemTable
{
    private static Dictionary<int, ItemInfo> Table = new Dictionary<int, ItemInfo>();

    public static Dictionary<int, ItemInfo> GetAll()
    {
        return Table;
    }

    public static ItemInfo GetByKey(int key)
    {
        ItemInfo value;

        if (Table.TryGetValue(key, out value))
            return value;

        return null;
    }

    public static ItemInfo GetByIndex(int index)
    {
        return Table.Values.ElementAt(index);
    }

    public static List<ItemInfo> GetAllList()
    {
        return Table.Values.ToList();
    }

    public ItemTable()
    {
        InitTable();
    }

    private void InitTable()
    {
        TextAsset textAsset = Resources.Load("Tables/Item") as TextAsset;
        MemoryStream memoryStream = new MemoryStream(textAsset.bytes);
        BinaryReader binaryReader = new BinaryReader(memoryStream);

        int tableCount = binaryReader.ReadInt32();

        for( int i = 0; i < tableCount; ++i)
        {
            int key = binaryReader.ReadInt32();

            ItemInfo info = new ItemInfo();
            info.SetID(binaryReader.ReadInt32());
            info.SetAddHealth(binaryReader.ReadSingle());
            info.SetAddAttack(binaryReader.ReadSingle());
            info.SetAddDefense(binaryReader.ReadSingle());
            info.SetName(binaryReader.ReadString());

            Table.Add(key, info);
        }
    }
}

public class LevelTable
{
    private static Dictionary<int, LevelInfo> Table = new Dictionary<int, LevelInfo>();

    public static Dictionary<int, LevelInfo> GetAll()
    {
        return Table;
    }

    public static LevelInfo GetByKey(int key)
    {
        LevelInfo value;

        if (Table.TryGetValue(key, out value))
            return value;

        return null;
    }

    public static LevelInfo GetByIndex(int index)
    {
        return Table.Values.ElementAt(index);
    }

    public static List<LevelInfo> GetAllList()
    {
        return Table.Values.ToList();
    }

    public LevelTable()
    {
        InitTable();
    }

    private void InitTable()
    {
        TextAsset textAsset = Resources.Load("Tables/Level") as TextAsset;
        MemoryStream memoryStream = new MemoryStream(textAsset.bytes);
        BinaryReader binaryReader = new BinaryReader(memoryStream);

        int tableCount = binaryReader.ReadInt32();

        for( int i = 0; i < tableCount; ++i)
        {
            int key = binaryReader.ReadInt32();

            LevelInfo info = new LevelInfo();
            info.SetID(binaryReader.ReadInt32());
            info.SetAddHealth(binaryReader.ReadSingle());
            info.SetAddAttack(binaryReader.ReadSingle());
            info.SetAddDefense(binaryReader.ReadSingle());

            Table.Add(key, info);
        }
    }
}

public class PlayerTable
{
    private static Dictionary<int, PlayerInfo> Table = new Dictionary<int, PlayerInfo>();

    public static Dictionary<int, PlayerInfo> GetAll()
    {
        return Table;
    }

    public static PlayerInfo GetByKey(int key)
    {
        PlayerInfo value;

        if (Table.TryGetValue(key, out value))
            return value;

        return null;
    }

    public static PlayerInfo GetByIndex(int index)
    {
        return Table.Values.ElementAt(index);
    }

    public static List<PlayerInfo> GetAllList()
    {
        return Table.Values.ToList();
    }

    public PlayerTable()
    {
        InitTable();
    }

    private void InitTable()
    {
        TextAsset textAsset = Resources.Load("Tables/Player") as TextAsset;
        MemoryStream memoryStream = new MemoryStream(textAsset.bytes);
        BinaryReader binaryReader = new BinaryReader(memoryStream);

        int tableCount = binaryReader.ReadInt32();

        for( int i = 0; i < tableCount; ++i)
        {
            int key = binaryReader.ReadInt32();

            PlayerInfo info = new PlayerInfo();
            info.SetID(binaryReader.ReadInt32());
            info.SetName(binaryReader.ReadString());
            info.SetBaseHealth(binaryReader.ReadInt32());
            info.SetBaseAttack(binaryReader.ReadInt32());
            info.SetBaseDefense(binaryReader.ReadInt32());

            Table.Add(key, info);
        }
    }
}


public class Tables : MonoBehaviour
{
    public EnemyTable Enemy = null;
    public ItemTable Item = null;
    public LevelTable Level = null;
    public PlayerTable Player = null;
    public CharacterBehaviorInfoTable CharacterBehaviorInfo = null;

    private static Tables instance = null;

    public static Tables Instance
    {
        get { return instance; }
    }

    void Awake() 
    {
        if (instance == null)
        {
            instance = this;

            Enemy = new EnemyTable();
            Item = new ItemTable();
            Level = new LevelTable();
            Player = new PlayerTable();
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
    }
}

