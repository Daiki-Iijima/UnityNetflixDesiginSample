using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ExpentionToggle))]
public class ToggleExpentionEditor : Editor
{
    public override void OnInspectorGUI()
    {
        // 各変数の型通りに表示する
        base.OnInspectorGUI();
    }
}
