using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private ScoreManager scoreManager;

    private PauseMenu pauseMenu;

    public GameObject GameOverUI;

    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        pauseMenu = FindObjectOfType<PauseMenu>();
    }

    public void GameOver()
    {
        pauseMenu.isDead = true;
        scoreManager.isDead = true;
        GameOverUI.SetActive(true);
        Time.timeScale = 0f;
        AudioListener.pause = true;
   
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        AudioListener.pause = false;
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
        AudioListener.pause = false;
    }

}
