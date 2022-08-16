using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class UIMainMenu : MonoBehaviour
{
    // Initialize UI elements
    [SerializeField] private TMP_InputField nameField;
    [SerializeField] private TMP_Text highscoreText;

    // Start is called before the first frame update
    void Start()
    {
        string name = GameManager.Instance.userName;
        int highscore = GameManager.Instance.highScore;
        highscoreText.text = name + " Highscore: " + highscore;
    }

    // When the user clicked the Start button, the main scene loads
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
