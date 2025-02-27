using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.UI; // Asegura importar esto para usar UI

public class MainMenu : MonoBehaviour
{
    public InputField nameInputField; // Asigna el InputField desde el Inspector
    public Text highScoreText; // Asigna el Text desde el Inspector

    void Start()
    {
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = "Récord: " + highScore;
    }


public void StartNew()
    {
        if (nameInputField != null && !string.IsNullOrWhiteSpace(nameInputField.text))
        {
            PlayerPrefs.SetString("PlayerName", nameInputField.text);
            PlayerPrefs.Save();
        }

        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}

