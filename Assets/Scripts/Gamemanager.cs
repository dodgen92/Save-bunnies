
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Gamemanager : MonoBehaviour
{
    // static instance of game manager

    public static Gamemanager instance;
    bool gameOver = false;
    int score = 0;
    //game over panel
    public GameObject gameOverPanel;
    public Text scoreText;
    public Text scoreTextPanel;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    public void GameOver()
    {
        gameOver = true;
        GameObject.Find("EnemySpawn").GetComponent<EnemySpawner>().StopSpawning();
        scoreTextPanel.text = "Score: " + score;
        gameOverPanel.SetActive(true);
    
    }
    public void IncrementScore()
    {
        if (!gameOver)
        {
            score++;
            print(score);
        }
        scoreText.text = score.ToString();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

}
