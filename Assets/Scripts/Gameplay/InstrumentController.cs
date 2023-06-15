using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InstrumentController : MonoBehaviour
{
    public UnityEvent OnRightNote;
    [Space]
    [SerializeField] private GameObject clicker;
    
    public static UnityAction<Vector3> onPlayNote;

    private void OnMouseDown()
    {
        clicker.SetActive(true);
        onPlayNote.Invoke(transform.position);
    }

    private void OnMouseUp()
    {
        clicker.SetActive(false);
    }
}
