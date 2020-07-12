
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    // static instance of game manager

    public static Gamemanager instance;
    bool gameOver = false;
    int score = 0;
    public Text scoreText;
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

}
