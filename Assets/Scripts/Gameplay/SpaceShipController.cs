using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpaceShipController : MonoBehaviour
{
    private void OnEnable()
    {
        InstrumentController.onPlayNote += OnPlayNote;
    }

    private void OnDisable()
    {
        InstrumentController.onPlayNote -= OnPlayNote;
    }

    private void OnPlayNote(Vector3 value)
    {
        transform.position = value;
    }
}
