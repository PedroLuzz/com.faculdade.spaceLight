using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LostScreen : MonoBehaviour
{
    [SerializeField] private Button btnContinue;
    [SerializeField] private Button btnTryAgain;

    private void Start()
    {
        btnContinue.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Main");
        });
        btnTryAgain.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Gameplay");
        });
    }
}
