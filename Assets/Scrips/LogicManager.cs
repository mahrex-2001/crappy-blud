using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{
    private int gameScore = 0;
    public Text gameText;

    public GameObject gameOver;

    // Levelling up the score for our blud! :D 
    [ContextMenu("ADD")]
    public void addScore(int val)
    {
        gameScore += val;
        gameText.text = gameScore.ToString();
    }

    public void restartGame()
    {
        gameScore = 0;

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOverScene()
    {
        gameOver.SetActive(true);
    }
}
