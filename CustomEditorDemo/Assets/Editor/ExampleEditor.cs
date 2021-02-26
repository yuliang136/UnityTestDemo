using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Example))]
public class ExampleEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        // 这个target从哪里来
        Example _example = target as Example;

        if (GUILayout.Button("执行Example方法"))
        {
            _example.LogError();
        }
    }
}
