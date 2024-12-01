using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    public InputField NameField;
    public Button startButton;
    private string nameOfPlayer;

    void Start()
    {
        startButton.onClick.AddListener(StartNew);
    }
    
    void Update()
    {
        GetPlayerName();
    }

    void GetPlayerName()
    {
        nameOfPlayer = NameField.GetComponent<InputField>().text;
    }

    void StartNew()
    {
        SceneManager.LoadScene(1);
    }

}
