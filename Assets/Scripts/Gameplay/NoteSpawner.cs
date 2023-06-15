using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    [SerializeField] private NoteController notePrefab;
    [Space]
    [SerializeField] private Transform position1;
    [SerializeField] private Transform position2;
    [SerializeField] private Transform position3;
    [SerializeField] private Transform position4;

    private void OnEnable()
    {
        NoteManager.OnTick += NoteManager_OnTick;
    }

    private void OnDisable()
    {
        NoteManager.OnTick -= NoteManager_OnTick;
    }

    private void NoteManager_OnTick(object sender, NoteManager.OnTickEventArgs e)
    {
        var finalTransform = position1;

        if(e.note.note1)
            finalTransform = position1;
        if(e.note.note2)
            finalTransform = position2;
        if(e.note.note3)
            finalTransform = position3;
        if(e.note.note4)
            finalTransform = position4;

        var note = Instantiate(notePrefab, finalTransform.position, Quaternion.identity);
    }
}
