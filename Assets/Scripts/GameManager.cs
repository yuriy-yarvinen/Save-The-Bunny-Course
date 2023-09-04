using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    int score = 0;

    bool gameOver = false;

    public TextMeshProUGUI scoreTextComponent;
 

    private void Awake() {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void GameOver () 
    {
        gameOver = true;

        GameObject.Find("EnemySpawn").GetComponent<EnemySpawner>().StopSpawning();    
    }

    public void IncrementScore () {
        if(!gameOver) {
            score++;
            scoreTextComponent.text = score.ToString();
        }
    }

}
