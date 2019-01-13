using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class DisplayTables : MonoBehaviour
{
    Vector2 m_scrollPosSheet = new Vector2();
    Vector2 m_scrollPosTable = new Vector2();

    Rect m_rectSheet = new Rect(0, 35, 980, 80);
    Rect m_rectTable = new Rect(0, 120, 980, 500);

    bool canShowEnemy = false;
    bool canShowItem = false;
    bool canShowLevel = false;
    bool canShowPlayer = false;
    bool canShowSheet1 = false;

    void Init()
    {
        canShowEnemy = false;
        canShowItem = false;
        canShowLevel = false;
        canShowPlayer = false;
        canShowSheet1 = false;
    }

    void Start ()
    {
        TestExample();
    }

    void TestExample()
    {
        var EnemyAll = EnemyTable.GetAll();
        var EnemyIndex = EnemyTable.GetByIndex(0);
        var EnemyKey = EnemyTable.GetByKey("200001");
        var EnemyList = EnemyTable.GetAllList();

        Debug.Log(" < ---EnemyTable Dictionary --->");

        foreach (var item in EnemyAll)
            Debug.Log(string.Format("Key = {0}, m_ID = {1},m_Name = {2},m_BaseHealth = {3},m_PlayerHealth = {4},m_BaseDefense = {5},", item.Key ,item.Value.m_ID ,item.Value.m_Name ,item.Value.m_BaseHealth ,item.Value.m_PlayerHealth ,item.Value.m_BaseDefense));

        Debug.Log(" < ---EnemyTable Dictionary Index --->");
        Debug.Log(string.Format("m_ID = {0},m_Name = {1},m_BaseHealth = {2},m_PlayerHealth = {3},m_BaseDefense = {4}," ,EnemyIndex.m_ID ,EnemyIndex.m_Name ,EnemyIndex.m_BaseHealth ,EnemyIndex.m_PlayerHealth ,EnemyIndex.m_BaseDefense));

        Debug.Log(" < ---EnemyTable Dictionary Key --->");
        Debug.Log(string.Format("m_ID = {0},m_Name = {1},m_BaseHealth = {2},m_PlayerHealth = {3},m_BaseDefense = {4}," ,EnemyKey.m_ID ,EnemyKey.m_Name ,EnemyKey.m_BaseHealth ,EnemyKey.m_PlayerHealth ,EnemyKey.m_BaseDefense));

        Debug.Log(" < ---EnemyTable List --->");

        foreach (var item in EnemyList)
            Debug.Log(string.Format("m_ID = {0},m_Name = {1},m_BaseHealth = {2},m_PlayerHealth = {3},m_BaseDefense = {4}," ,item.m_ID ,item.m_Name ,item.m_BaseHealth ,item.m_PlayerHealth ,item.m_BaseDefense));

        var ItemAll = ItemTable.GetAll();
        var ItemIndex = ItemTable.GetByIndex(0);
        var ItemKey = ItemTable.GetByKey(30000001);
        var ItemList = ItemTable.GetAllList();

        Debug.Log(" < ---ItemTable Dictionary --->");

        foreach (var item in ItemAll)
            Debug.Log(string.Format("Key = {0}, m_ID = {1},m_AddHealth = {2},m_AddAttack = {3},m_AddDefense = {4},m_Name = {5},", item.Key ,item.Value.m_ID ,item.Value.m_AddHealth ,item.Value.m_AddAttack ,item.Value.m_AddDefense ,item.Value.m_Name));

        Debug.Log(" < ---ItemTable Dictionary Index --->");
        Debug.Log(string.Format("m_ID = {0},m_AddHealth = {1},m_AddAttack = {2},m_AddDefense = {3},m_Name = {4}," ,ItemIndex.m_ID ,ItemIndex.m_AddHealth ,ItemIndex.m_AddAttack ,ItemIndex.m_AddDefense ,ItemIndex.m_Name));

        Debug.Log(" < ---ItemTable Dictionary Key --->");
        Debug.Log(string.Format("m_ID = {0},m_AddHealth = {1},m_AddAttack = {2},m_AddDefense = {3},m_Name = {4}," ,ItemKey.m_ID ,ItemKey.m_AddHealth ,ItemKey.m_AddAttack ,ItemKey.m_AddDefense ,ItemKey.m_Name));

        Debug.Log(" < ---ItemTable List --->");

        foreach (var item in ItemList)
            Debug.Log(string.Format("m_ID = {0},m_AddHealth = {1},m_AddAttack = {2},m_AddDefense = {3},m_Name = {4}," ,item.m_ID ,item.m_AddHealth ,item.m_AddAttack ,item.m_AddDefense ,item.m_Name));

        var LevelAll = LevelTable.GetAll();
        var LevelIndex = LevelTable.GetByIndex(0);
        var LevelKey = LevelTable.GetByKey(1);
        var LevelList = LevelTable.GetAllList();

        Debug.Log(" < ---LevelTable Dictionary --->");

        foreach (var item in LevelAll)
            Debug.Log(string.Format("Key = {0}, m_ID = {1},m_AddHealth = {2},m_AddAttack = {3},m_AddDefense = {4},", item.Key ,item.Value.m_ID ,item.Value.m_AddHealth ,item.Value.m_AddAttack ,item.Value.m_AddDefense));

        Debug.Log(" < ---LevelTable Dictionary Index --->");
        Debug.Log(string.Format("m_ID = {0},m_AddHealth = {1},m_AddAttack = {2},m_AddDefense = {3}," ,LevelIndex.m_ID ,LevelIndex.m_AddHealth ,LevelIndex.m_AddAttack ,LevelIndex.m_AddDefense));

        Debug.Log(" < ---LevelTable Dictionary Key --->");
        Debug.Log(string.Format("m_ID = {0},m_AddHealth = {1},m_AddAttack = {2},m_AddDefense = {3}," ,LevelKey.m_ID ,LevelKey.m_AddHealth ,LevelKey.m_AddAttack ,LevelKey.m_AddDefense));

        Debug.Log(" < ---LevelTable List --->");

        foreach (var item in LevelList)
            Debug.Log(string.Format("m_ID = {0},m_AddHealth = {1},m_AddAttack = {2},m_AddDefense = {3}," ,item.m_ID ,item.m_AddHealth ,item.m_AddAttack ,item.m_AddDefense));

        var PlayerAll = PlayerTable.GetAll();
        var PlayerIndex = PlayerTable.GetByIndex(0);
        var PlayerKey = PlayerTable.GetByKey(100001);
        var PlayerList = PlayerTable.GetAllList();

        Debug.Log(" < ---PlayerTable Dictionary --->");

        foreach (var item in PlayerAll)
            Debug.Log(string.Format("Key = {0}, m_ID = {1},m_Name = {2},m_BaseHealth = {3},m_BaseAttack = {4},m_BaseDefense = {5},", item.Key ,item.Value.m_ID ,item.Value.m_Name ,item.Value.m_BaseHealth ,item.Value.m_BaseAttack ,item.Value.m_BaseDefense));

        Debug.Log(" < ---PlayerTable Dictionary Index --->");
        Debug.Log(string.Format("m_ID = {0},m_Name = {1},m_BaseHealth = {2},m_BaseAttack = {3},m_BaseDefense = {4}," ,PlayerIndex.m_ID ,PlayerIndex.m_Name ,PlayerIndex.m_BaseHealth ,PlayerIndex.m_BaseAttack ,PlayerIndex.m_BaseDefense));

        Debug.Log(" < ---PlayerTable Dictionary Key --->");
        Debug.Log(string.Format("m_ID = {0},m_Name = {1},m_BaseHealth = {2},m_BaseAttack = {3},m_BaseDefense = {4}," ,PlayerKey.m_ID ,PlayerKey.m_Name ,PlayerKey.m_BaseHealth ,PlayerKey.m_BaseAttack ,PlayerKey.m_BaseDefense));

        Debug.Log(" < ---PlayerTable List --->");

        foreach (var item in PlayerList)
            Debug.Log(string.Format("m_ID = {0},m_Name = {1},m_BaseHealth = {2},m_BaseAttack = {3},m_BaseDefense = {4}," ,item.m_ID ,item.m_Name ,item.m_BaseHealth ,item.m_BaseAttack ,item.m_BaseDefense));

        var Sheet1All = Sheet1Table.GetAll();
        var Sheet1Index = Sheet1Table.GetByIndex(0);
        var Sheet1Key = Sheet1Table.GetByKey(1601);
        var Sheet1List = Sheet1Table.GetAllList();

        Debug.Log(" < ---Sheet1Table Dictionary --->");

        foreach (var item in Sheet1All)
            Debug.Log(string.Format("Key = {0}, m_name = {1},m_targetObject_Type = {2},m_behaviorProperties1 = {3},m_behaviorProperties2 = {4},m_value1 = {5},m_value2 = {6},m_behaviorCondition1 = {7},m_behaviorCondition2 = {8},m_behaviorType = {9},m_behaviorRate = {10},", item.Key ,item.Value.m_name ,item.Value.m_targetObject_Type ,item.Value.m_behaviorProperties1 ,item.Value.m_behaviorProperties2 ,item.Value.m_value1 ,item.Value.m_value2 ,item.Value.m_behaviorCondition1 ,item.Value.m_behaviorCondition2 ,item.Value.m_behaviorType ,item.Value.m_behaviorRate));

        Debug.Log(" < ---Sheet1Table Dictionary Index --->");
        Debug.Log(string.Format("m_name = {0},m_targetObject_Type = {1},m_behaviorProperties1 = {2},m_behaviorProperties2 = {3},m_value1 = {4},m_value2 = {5},m_behaviorCondition1 = {6},m_behaviorCondition2 = {7},m_behaviorType = {8},m_behaviorRate = {9}," ,Sheet1Index.m_name ,Sheet1Index.m_targetObject_Type ,Sheet1Index.m_behaviorProperties1 ,Sheet1Index.m_behaviorProperties2 ,Sheet1Index.m_value1 ,Sheet1Index.m_value2 ,Sheet1Index.m_behaviorCondition1 ,Sheet1Index.m_behaviorCondition2 ,Sheet1Index.m_behaviorType ,Sheet1Index.m_behaviorRate));

        Debug.Log(" < ---Sheet1Table Dictionary Key --->");
        Debug.Log(string.Format("m_name = {0},m_targetObject_Type = {1},m_behaviorProperties1 = {2},m_behaviorProperties2 = {3},m_value1 = {4},m_value2 = {5},m_behaviorCondition1 = {6},m_behaviorCondition2 = {7},m_behaviorType = {8},m_behaviorRate = {9}," ,Sheet1Key.m_name ,Sheet1Key.m_targetObject_Type ,Sheet1Key.m_behaviorProperties1 ,Sheet1Key.m_behaviorProperties2 ,Sheet1Key.m_value1 ,Sheet1Key.m_value2 ,Sheet1Key.m_behaviorCondition1 ,Sheet1Key.m_behaviorCondition2 ,Sheet1Key.m_behaviorType ,Sheet1Key.m_behaviorRate));

        Debug.Log(" < ---Sheet1Table List --->");

        foreach (var item in Sheet1List)
            Debug.Log(string.Format("m_name = {0},m_targetObject_Type = {1},m_behaviorProperties1 = {2},m_behaviorProperties2 = {3},m_value1 = {4},m_value2 = {5},m_behaviorCondition1 = {6},m_behaviorCondition2 = {7},m_behaviorType = {8},m_behaviorRate = {9}," ,item.m_name ,item.m_targetObject_Type ,item.m_behaviorProperties1 ,item.m_behaviorProperties2 ,item.m_value1 ,item.m_value2 ,item.m_behaviorCondition1 ,item.m_behaviorCondition2 ,item.m_behaviorType ,item.m_behaviorRate));

    }

    void OnGUI()
    {
        GUILayout.BeginArea(m_rectSheet, GUI.skin.box);
        {
            m_scrollPosSheet = GUILayout.BeginScrollView(m_scrollPosSheet, true, true);
            {
                GUILayout.BeginHorizontal(GUI.skin.button);
                {
                    if (GUILayout.Button("Enemy", GUILayout.Width(200), GUILayout.Height(30)))
                    {
                        Init();
                        canShowEnemy = true;
                    }

                    if (GUILayout.Button("Item", GUILayout.Width(200), GUILayout.Height(30)))
                    {
                        Init();
                        canShowItem = true;
                    }

                    if (GUILayout.Button("Level", GUILayout.Width(200), GUILayout.Height(30)))
                    {
                        Init();
                        canShowLevel = true;
                    }

                    if (GUILayout.Button("Player", GUILayout.Width(200), GUILayout.Height(30)))
                    {
                        Init();
                        canShowPlayer = true;
                    }

                    if (GUILayout.Button("Sheet1", GUILayout.Width(200), GUILayout.Height(30)))
                    {
                        Init();
                        canShowSheet1 = true;
                    }

                }
                GUILayout.EndHorizontal();
            }
            GUILayout.EndScrollView();
        }
        GUILayout.EndArea();

        if (canShowEnemy)
        {
            GUILayout.BeginArea(m_rectTable, GUI.skin.box);
            {
                if (EnemyTable.GetAll().Count > 0)
                {
                    m_scrollPosTable = GUILayout.BeginScrollView(m_scrollPosTable, true, true);
                    {
                        GUILayout.BeginVertical(GUI.skin.box);
                        {
                            foreach (var info in EnemyTable.GetAll())
                            {
                                GUILayout.BeginHorizontal(GUI.skin.box);
                                {
                                    GUILayout.TextField("Key: " + info.Key.ToString(), GUI.skin.box, GUILayout.Width(200), GUILayout.Height(30));
                                    GUILayout.TextField("", GUI.skin.box, GUILayout.Width(30), GUILayout.Height(30));
                                    GUILayout.TextField("ID: " + info.Value.m_ID.ToString(), GUI.skin.box, GUILayout.Width(150), GUILayout.Height(30));
                                    GUILayout.TextField("Name: " + info.Value.m_Name.ToString(), GUI.skin.box, GUILayout.Width(150), GUILayout.Height(30));
                                    GUILayout.TextField("BaseHealth: " + info.Value.m_BaseHealth.ToString(), GUI.skin.box, GUILayout.Width(150), GUILayout.Height(30));
                                    GUILayout.TextField("PlayerHealth: " + info.Value.m_PlayerHealth.ToString(), GUI.skin.box, GUILayout.Width(150), GUILayout.Height(30));
                                    GUILayout.TextField("BaseDefense: " + info.Value.m_BaseDefense.ToString(), GUI.skin.box, GUILayout.Width(150), GUILayout.Height(30));
                                }
                                GUILayout.EndHorizontal();
                            }
                        }
                        GUILayout.EndVertical();
                    }
                    GUILayout.EndScrollView();
                }
            }
            GUILayout.EndArea();
        }

        if (canShowItem)
        {
            GUILayout.BeginArea(m_rectTable, GUI.skin.box);
            {
                if (ItemTable.GetAll().Count > 0)
                {
                    m_scrollPosTable = GUILayout.BeginScrollView(m_scrollPosTable, true, true);
                    {
                        GUILayout.BeginVertical(GUI.skin.box);
                        {
                            foreach (var info in ItemTable.GetAll())
                            {
                                GUILayout.BeginHorizontal(GUI.skin.box);
                                {
                                    GUILayout.TextField("Key: " + info.Key.ToString(), GUI.skin.box, GUILayout.Width(200), GUILayout.Height(30));
                                    GUILayout.TextField("", GUI.skin.box, GUILayout.Width(30), GUILayout.Height(30));
                                    GUILayout.TextField("ID: " + info.Value.m_ID.ToString(), GUI.skin.box, GUILayout.Width(150), GUILayout.Height(30));
                                    GUILayout.TextField("AddHealth: " + info.Value.m_AddHealth.ToString(), GUI.skin.box, GUILayout.Width(150), GUILayout.Height(30));
                                    GUILayout.TextField("AddAttack: " + info.Value.m_AddAttack.ToString(), GUI.skin.box, GUILayout.Width(150), GUILayout.Height(30));
                                    GUILayout.TextField("AddDefense: " + info.Value.m_AddDefense.ToString(), GUI.skin.box, GUILayout.Width(150), GUILayout.Height(30));
                                    GUILayout.TextField("Name: " + info.Value.m_Name.ToString(), GUI.skin.box, GUILayout.Width(150), GUILayout.Height(30));
                                }
                                GUILayout.EndHorizontal();
                            }
                        }
                        GUILayout.EndVertical();
                    }
                    GUILayout.EndScrollView();
                }
            }
            GUILayout.EndArea();
        }

        if (canShowLevel)
        {
            GUILayout.BeginArea(m_rectTable, GUI.skin.box);
            {
                if (LevelTable.GetAll().Count > 0)
                {
                    m_scrollPosTable = GUILayout.BeginScrollView(m_scrollPosTable, true, true);
                    {
                        GUILayout.BeginVertical(GUI.skin.box);
                        {
                            foreach (var info in LevelTable.GetAll())
                            {
                                GUILayout.BeginHorizontal(GUI.skin.box);
                                {
                                    GUILayout.TextField("Key: " + info.Key.ToString(), GUI.skin.box, GUILayout.Width(200), GUILayout.Height(30));
                                    GUILayout.TextField("", GUI.skin.box, GUILayout.Width(30), GUILayout.Height(30));
                                    GUILayout.TextField("ID: " + info.Value.m_ID.ToString(), GUI.skin.box, GUILayout.Width(150), GUILayout.Height(30));
                                    GUILayout.TextField("AddHealth: " + info.Value.m_AddHealth.ToString(), GUI.skin.box, GUILayout.Width(150), GUILayout.Height(30));
                                    GUILayout.TextField("AddAttack: " + info.Value.m_AddAttack.ToString(), GUI.skin.box, GUILayout.Width(150), GUILayout.Height(30));
                                    GUILayout.TextField("AddDefense: " + info.Value.m_AddDefense.ToString(), GUI.skin.box, GUILayout.Width(150), GUILayout.Height(30));
                                }
                                GUILayout.EndHorizontal();
                            }
                        }
                        GUILayout.EndVertical();
                    }
                    GUILayout.EndScrollView();
                }
            }
            GUILayout.EndArea();
        }

        if (canShowPlayer)
        {
            GUILayout.BeginArea(m_rectTable, GUI.skin.box);
            {
                if (PlayerTable.GetAll().Count > 0)
                {
                    m_scrollPosTable = GUILayout.BeginScrollView(m_scrollPosTable, true, true);
                    {
                        GUILayout.BeginVertical(GUI.skin.box);
                        {
                            foreach (var info in PlayerTable.GetAll())
                            {
                                GUILayout.BeginHorizontal(GUI.skin.box);
                                {
                                    GUILayout.TextField("Key: " + info.Key.ToString(), GUI.skin.box, GUILayout.Width(200), GUILayout.Height(30));
                                    GUILayout.TextField("", GUI.skin.box, GUILayout.Width(30), GUILayout.Height(30));
                                    GUILayout.TextField("ID: " + info.Value.m_ID.ToString(), GUI.skin.box, GUILayout.Width(150), GUILayout.Height(30));
                                    GUILayout.TextField("Name: " + info.Value.m_Name.ToString(), GUI.skin.box, GUILayout.Width(150), GUILayout.Height(30));
                                    GUILayout.TextField("BaseHealth: " + info.Value.m_BaseHealth.ToString(), GUI.skin.box, GUILayout.Width(150), GUILayout.Height(30));
                                    GUILayout.TextField("BaseAttack: " + info.Value.m_BaseAttack.ToString(), GUI.skin.box, GUILayout.Width(150), GUILayout.Height(30));
                                    GUILayout.TextField("BaseDefense: " + info.Value.m_BaseDefense.ToString(), GUI.skin.box, GUILayout.Width(150), GUILayout.Height(30));
                                }
                                GUILayout.EndHorizontal();
                            }
                        }
                        GUILayout.EndVertical();
                    }
                    GUILayout.EndScrollView();
                }
            }
            GUILayout.EndArea();
        }

        if (canShowSheet1)
        {
            GUILayout.BeginArea(m_rectTable, GUI.skin.box);
            {
                if (Sheet1Table.GetAll().Count > 0)
                {
                    m_scrollPosTable = GUILayout.BeginScrollView(m_scrollPosTable, true, true);
                    {
                        GUILayout.BeginVertical(GUI.skin.box);
                        {
                            foreach (var info in Sheet1Table.GetAll())
                            {
                                GUILayout.BeginHorizontal(GUI.skin.box);
                                {
                                    GUILayout.TextField("Key: " + info.Key.ToString(), GUI.skin.box, GUILayout.Width(200), GUILayout.Height(30));
                                    GUILayout.TextField("", GUI.skin.box, GUILayout.Width(30), GUILayout.Height(30));
                                    GUILayout.TextField("name: " + info.Value.m_name.ToString(), GUI.skin.box, GUILayout.Width(150), GUILayout.Height(30));
                                    GUILayout.TextField("targetObject_Type: " + info.Value.m_targetObject_Type.ToString(), GUI.skin.box, GUILayout.Width(150), GUILayout.Height(30));
                                    GUILayout.TextField("behaviorProperties1: " + info.Value.m_behaviorProperties1.ToString(), GUI.skin.box, GUILayout.Width(150), GUILayout.Height(30));
                                    GUILayout.TextField("behaviorProperties2: " + info.Value.m_behaviorProperties2.ToString(), GUI.skin.box, GUILayout.Width(150), GUILayout.Height(30));
                                    GUILayout.TextField("value1: " + info.Value.m_value1.ToString(), GUI.skin.box, GUILayout.Width(150), GUILayout.Height(30));
                                    GUILayout.TextField("value2: " + info.Value.m_value2.ToString(), GUI.skin.box, GUILayout.Width(150), GUILayout.Height(30));
                                    GUILayout.TextField("behaviorCondition1: " + info.Value.m_behaviorCondition1.ToString(), GUI.skin.box, GUILayout.Width(150), GUILayout.Height(30));
                                    GUILayout.TextField("behaviorCondition2: " + info.Value.m_behaviorCondition2.ToString(), GUI.skin.box, GUILayout.Width(150), GUILayout.Height(30));
                                    GUILayout.TextField("behaviorType: " + info.Value.m_behaviorType.ToString(), GUI.skin.box, GUILayout.Width(150), GUILayout.Height(30));
                                    GUILayout.TextField("behaviorRate: " + info.Value.m_behaviorRate.ToString(), GUI.skin.box, GUILayout.Width(150), GUILayout.Height(30));
                                }
                                GUILayout.EndHorizontal();
                            }
                        }
                        GUILayout.EndVertical();
                    }
                    GUILayout.EndScrollView();
                }
            }
            GUILayout.EndArea();
        }

    }
}

