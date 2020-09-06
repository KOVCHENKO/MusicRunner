using UnityEditor;
using UnityEngine;

namespace Util
{
    [CustomEditor(typeof(MainMenuManager))]
    public class GameManagerEditor : Editor
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