using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NoteDestroyer : MonoBehaviour
{
    public UnityEvent OnDestroyNode;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("destroy note");

        if (collision.TryGetComponent<NoteController>(out NoteController note))
        {
            
            note.DestrySelf();
            OnDestroyNode?.Invoke();
        }
    }
}
