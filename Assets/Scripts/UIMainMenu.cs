using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
#endif

[DefaultExecutionOrder(1000)]
public class UIMainMenu : MonoBehaviour
{
    // Initialize UI elements
    [SerializeField] private TMP_InputField nameField;
    [SerializeField] private TMP_Text highscoreText;

    // Start is called before the first frame update
    void Start()
    {
        string name = GameManager.Instance.userName;
        string currentUsername = GameManager.Instance.currentUserName;
        int highscore = GameManager.Instance.highScore;

        if (name == "")
        {
            // if this is the player's first time playing this game
            highscoreText.text = "Start playing to get your highscore!";
        } else
        {
            highscoreText.text = name + "'s Highscore: " + highscore;
        }

        nameField.text = currentUsername;
    }

    // When the user clicked the Start button, the main scene loads
    public void StartGame()
    {
        GameManager.Instance.currentUserName = nameField.text;
        SceneManager.LoadScene(1);
    }

    // When the player wants to quit the game
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
