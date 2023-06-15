using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SongMenuItem : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI txtName;
    [SerializeField] private Button btnSelect;

    private SongData song;

    private void Start()
    {
        btnSelect.onClick.AddListener(BtnSelectOnClick);
    }

    public void Fill(SongData song)
    {
        txtName.text = song.songName;
        this.song = song;
    }

    private void BtnSelectOnClick()
    {
        NoteManager.songData = song;
        SceneManager.LoadScene("Gameplay");
    }
}
