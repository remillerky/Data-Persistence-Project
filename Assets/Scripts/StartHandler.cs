using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    public Text playerName;
    private string nameOfPlayer;

    void Start()
    {
        nameOfPlayer = playerName.text.ToString();
    }

    void StartNew()
    {
        SceneManager.LoadScene(1);
    }

}
