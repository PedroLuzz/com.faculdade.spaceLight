using System;
using UnityEngine;

public class NoteManager : MonoBehaviour
{
    [SerializeField] private SongData song;
    [Space]
    [SerializeField] private int maxLives = 5;
    [SerializeField] private int scoreAdd = 100;
    [Space]
    [SerializeField] private SongView songView;

    private int currentLives = 5;
    private int score = 0;

    private int tick;
    private int notesPlayed = 0;
    private float beat;
    private float tickTimer;
    private bool isPlayingSong = true;

    private AudioSource source;

    public static SongData songData;

    public class OnTickEventArgs : EventArgs
    {
        public int tick;
        public Note note;
    }

    public static event EventHandler<OnTickEventArgs> OnTick;

    private void Awake()
    {
        beat = song.beatsPerSecond;
        currentLives = maxLives;
        if(songData != null)
        {
            song = songData;
        }
    }

    private void Start()
    {
        isPlayingSong = true;
        if(song.audio != null)
        {
            source = gameObject.AddComponent<AudioSource>();
            source.loop = false;
            source.clip = song.audio;
            source.Play();
        }
        songView.UpdateView(score, currentLives);

        OnTick?.Invoke(this, new OnTickEventArgs { tick = tick, note = song.notes[tick] });
    }

    private void Update()
    {
        if(tick >= song.notes.Length - 1)
        {
            isPlayingSong = false;
            return;
        }

        if (!isPlayingSong) return;

        tickTimer += Time.deltaTime;
        if(tickTimer >= beat)
        {
            tickTimer -= beat;
            tick++;
            OnTick?.Invoke(this, new OnTickEventArgs { tick = tick, note = song.notes[tick] });
        }
    }

    public void NewScore()
    {
        notesPlayed++;
        if(notesPlayed >= song.notes.Length)
        {
            songView.ShowEnd(true);

        }
        score += scoreAdd;
        currentLives = maxLives;
        songView.UpdateView(score, currentLives);
    }

    public void LooseLife()
    {
        currentLives--;
        songView.UpdateView(score, currentLives);
        if(currentLives <= 0) 
        {
            source.Stop();
            isPlayingSong = false;
            songView.ShowEnd(false);
        }
    }
}
