using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VictoryScreen : MonoBehaviour
{
    [SerializeField] private Button btnContinue;

    private void Start()
    {
        btnContinue.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Main");
        });
    }
}
