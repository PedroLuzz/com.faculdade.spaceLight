using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Assets/new Song")]
public class SongData : ScriptableObject
{
    public string songName;
    public float beatsPerSecond;
    public AudioClip audio;
    public Note[] notes;

    [ContextMenu("Create Notes")]
    public void CreateNotes()
    {
        if (audio == null)
        {
            return;
        }

        var size = audio.length / beatsPerSecond;

        notes = new Note[(int)size];
    }
}

[Serializable]
public struct Note
{
    public bool note1;
    public bool note2;
    public bool note3;
    public bool note4;
}
