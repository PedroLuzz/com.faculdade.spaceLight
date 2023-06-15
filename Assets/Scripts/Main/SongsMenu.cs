using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongsMenu : MonoBehaviour
{
    [SerializeField] private Transform container;
    [SerializeField] private SongMenuItem prefab;

    private void Start()
    {
        SongData[] songs = Resources.LoadAll<SongData>("Songs");
        foreach (SongData s in songs)
        {
            var item = Instantiate(prefab, container);
            item.Fill(s);
        }
    }
}
