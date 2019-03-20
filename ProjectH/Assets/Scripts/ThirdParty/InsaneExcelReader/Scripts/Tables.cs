using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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

public class Sheet1Info
{
    public string m_name { get; private set; }
    public int m_targetObject_Type { get; private set; }
    public int m_behaviorProperties1 { get; private set; }
    public int m_behaviorProperties2 { get; private set; }
    public int m_value1 { get; private set; }
    public int m_value2 { get; private set; }
    public int m_behaviorCondition1 { get; private set; }
    public int m_behaviorCondition2 { get; private set; }
    public int m_behaviorType { get; private set; }
    public float m_behaviorRate { get; private set; }

    public void Setname(string name) { m_name = name; }
    public void SettargetObject_Type(int targetObject_Type) { m_targetObject_Type = targetObject_Type; }
    public void SetbehaviorProperties1(int behaviorProperties1) { m_behaviorProperties1 = behaviorProperties1; }
    public void SetbehaviorProperties2(int behaviorProperties2) { m_behaviorProperties2 = behaviorProperties2; }
    public void Setvalue1(int value1) { m_value1 = value1; }
    public void Setvalue2(int value2) { m_value2 = value2; }
    public void SetbehaviorCondition1(int behaviorCondition1) { m_behaviorCondition1 = behaviorCondition1; }
    public void SetbehaviorCondition2(int behaviorCondition2) { m_behaviorCondition2 = behaviorCondition2; }
    public void SetbehaviorType(int behaviorType) { m_behaviorType = behaviorType; }
    public void SetbehaviorRate(float behaviorRate) { m_behaviorRate = behaviorRate; }
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

public class Sheet1Table
{
    private static Dictionary<int, Sheet1Info> Table = new Dictionary<int, Sheet1Info>();

    public static Dictionary<int, Sheet1Info> GetAll()
    {
        return Table;
    }

    public static Sheet1Info GetByKey(int key)
    {
        Sheet1Info value;

        if (Table.TryGetValue(key, out value))
            return value;

        return null;
    }

    public static Sheet1Info GetByIndex(int index)
    {
        return Table.Values.ElementAt(index);
    }

    public static List<Sheet1Info> GetAllList()
    {
        return Table.Values.ToList();
    }

    public Sheet1Table()
    {
        InitTable();
    }

    private void InitTable()
    {
        TextAsset textAsset = Resources.Load("Tables/Sheet1") as TextAsset;
        MemoryStream memoryStream = new MemoryStream(textAsset.bytes);
        BinaryReader binaryReader = new BinaryReader(memoryStream);

        int tableCount = binaryReader.ReadInt32();

        for( int i = 0; i < tableCount; ++i)
        {
            int key = binaryReader.ReadInt32();

            Sheet1Info info = new Sheet1Info();
            info.Setname(binaryReader.ReadString());
            info.SettargetObject_Type(binaryReader.ReadInt32());
            info.SetbehaviorProperties1(binaryReader.ReadInt32());
            info.SetbehaviorProperties2(binaryReader.ReadInt32());
            info.Setvalue1(binaryReader.ReadInt32());
            info.Setvalue2(binaryReader.ReadInt32());
            info.SetbehaviorCondition1(binaryReader.ReadInt32());
            info.SetbehaviorCondition2(binaryReader.ReadInt32());
            info.SetbehaviorType(binaryReader.ReadInt32());
            info.SetbehaviorRate(binaryReader.ReadSingle());

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
    public Sheet1Table Sheet1 = null;

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
            Sheet1 = new Sheet1Table();
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }
}

