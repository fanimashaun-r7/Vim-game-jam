using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public GameObject GameOverUI;
    public Text highscore;

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "DeathCollider")
        {
            Debug.Log("OnCollisionEnter2Ddddd");
            GameOverUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void RestartButton() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenuButton() {
        SceneManager.LoadScene(0);
    }

}
