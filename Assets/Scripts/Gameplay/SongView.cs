using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SongView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI txtLives;
    [SerializeField] private TextMeshProUGUI txtScore;
    [SerializeField] private TextMeshProUGUI txtScoreEnd;
    [Space]
    [SerializeField] private GameObject victoryScreen;
    [SerializeField] private GameObject lostScreen;

    public void UpdateView(int score, int lives)
    {
        txtLives.text = lives.ToString();
        txtScoreEnd.text = txtScore.text = score.ToString();
        
    }

    public void ShowEnd(bool victory)
    {
        if (victory)
        {
            victoryScreen.SetActive(true);
        }
        else
        {
            lostScreen.SetActive(true);
        }
    }    
}
