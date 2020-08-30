﻿using UnityEditor;
using UnityEngine;
 using Util;

 namespace Editor
{
    [CustomEditor(typeof(MainMenuManager))]
    public class GameManagerEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            MainMenuManager gameManager = (MainMenuManager) target;

            if (GUILayout.Button("Reset Score"))
            {
                PlayerPrefManager.ResetLevelScores();
            }
            
            if (GUILayout.Button("Output Player State"))
            {
                PlayerPrefManager.ShowPlayerPrefs();
            }
            
        }
    }
}