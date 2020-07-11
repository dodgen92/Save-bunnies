
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // static instance of game manager

    public static GameManager instance;
    bool gameOver = false;
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


}
