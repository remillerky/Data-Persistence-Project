using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    public InputField NameField;
    private string nameOfPlayer;

    void Start()
    {
        
    }

    void Update()
    {
        GetPlayerName();
    }

    void GetPlayerName()
    {
        nameOfPlayer = NameField.GetComponent<InputField>().text;
        if(nameOfPlayer != null) { Debug.Log("Player's Name: " + nameOfPlayer); }
    }

    void StartNew()
    {
        SceneManager.LoadScene(1);
    }

}
