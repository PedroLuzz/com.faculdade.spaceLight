using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject songMenu;

    [Space]
    [SerializeField] private Button btnPlay;
    [SerializeField] private Button btnBack;

    private void Start()
    {
        btnPlay.onClick.AddListener(() =>
        {
            mainMenu.SetActive(false);
            songMenu.SetActive(true);
        });
        btnBack.onClick.AddListener(() =>
        {
            mainMenu.SetActive(true);
            songMenu.SetActive(false);
        });
    }
}
