using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(SongData))]
public class NoteDataEditor : Editor
{
    private SerializedProperty flowsProperty;
    private SerializedProperty songNameProperty;
    private SerializedProperty beatsPerSecondProperty;
    private SerializedProperty audioProperty;

    private void OnEnable()
    {
        flowsProperty = serializedObject.FindProperty("notes");
        songNameProperty = serializedObject.FindProperty("songName");
        beatsPerSecondProperty = serializedObject.FindProperty("beatsPerSecond");
        audioProperty = serializedObject.FindProperty("audio");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        EditorGUILayout.PropertyField(songNameProperty);
        EditorGUILayout.PropertyField(beatsPerSecondProperty);
        EditorGUILayout.PropertyField(audioProperty);

        EditorGUILayout.PropertyField(flowsProperty, true);

        if (flowsProperty.isExpanded)
        {
            EditorGUI.indentLevel++;

            for (int i = 0; i < flowsProperty.arraySize; i++)
            {
                SerializedProperty flowProperty = flowsProperty.GetArrayElementAtIndex(i);

                SerializedProperty note1Property = flowProperty.FindPropertyRelative("note1");
                SerializedProperty note2Property = flowProperty.FindPropertyRelative("note2");
                SerializedProperty note3Property = flowProperty.FindPropertyRelative("note3");
                SerializedProperty note4Property = flowProperty.FindPropertyRelative("note4");

                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.PropertyField(note1Property, GUIContent.none, GUILayout.Width(50));
                EditorGUILayout.PropertyField(note2Property, GUIContent.none, GUILayout.Width(50));
                EditorGUILayout.PropertyField(note3Property, GUIContent.none, GUILayout.Width(50));
                EditorGUILayout.PropertyField(note4Property, GUIContent.none, GUILayout.Width(50));
                EditorGUILayout.EndHorizontal();
            }

            EditorGUI.indentLevel--;
        }

        serializedObject.ApplyModifiedProperties();
    }
}
