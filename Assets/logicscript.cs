using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicscript : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public GameObject GameOverScreen;
    
    [ContextMenu("Increase Score")] 
    public void addScore(int scoreToAdd)
    {
        score+=scoreToAdd;
        scoreText.text=score.ToString();
    }
    public void restastGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        GameOverScreen.SetActive(true);
       
    }
}
