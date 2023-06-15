using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstrumentCollider : MonoBehaviour
{
    private InstrumentController controller;

    private void Awake()
    {
        controller = GetComponentInParent<InstrumentController>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("on trigger enter");

        if(collision.TryGetComponent<NoteController>(out NoteController note))
        {
            Debug.Log("hit note");
            note.DestrySelf();
            controller.OnRightNote?.Invoke();
        }
    }
}
