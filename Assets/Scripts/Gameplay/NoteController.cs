using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteController : MonoBehaviour
{
    public float speed = 5;

    private Transform _transform;

    private void Awake()
    {
        _transform = transform;
    }

    public void DestrySelf()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        _transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
