using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private ScoreManager scoreManager;

    public GameObject GameOverUI;

    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    public void GameOver()
    {
        scoreManager.isDead = true;
        GameOverUI.SetActive(true);
        Time.timeScale = 0f;

        
        
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

}
