using UnityEditor;

public class CheckTable : EditorWindow
{
    [MenuItem("Window/InsaneExcelReader/Check Table")]
    public static void Init()
    {
#if (UNITY_5_0 || UNITY_5_1 || UNITY_5_2)
        EditorApplication.OpenScene(@"Assets/InsaneExcelReader/Examples/Scenes/CheckTable.unity");
#elif (UNITY_5_3 || UNITY_5_4 || UNITY_5_5)
        UnityEditor.SceneManagement.EditorSceneManager.OpenScene(@"Assets/InsaneExcelReader/Examples/Scenes/CheckTable.unity");
#endif
        EditorApplication.ExecuteMenuItem("Edit/Play");
    }
}