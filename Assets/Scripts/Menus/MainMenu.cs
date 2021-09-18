using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button easy;
    public Button medium;
    public Button hard;
    public Button proGamer;

    public int difficulty;

    // Start is called before the first frame update
    public void PlayGames()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void EasyDif()
    {
        difficulty = 1;
        PlayerPrefs.SetInt("Difficulty", difficulty);
        PlayGames();
    }

    public void MediumDif()
    {
        difficulty = 2;
        PlayerPrefs.SetInt("Difficulty", difficulty);
        PlayGames();
    }

    public void HardDif()
    {
        difficulty = 3;
        PlayerPrefs.SetInt("Difficulty", difficulty);
        PlayGames();
    }

    public void ProGamerDif()
    {
        difficulty = 4;
        PlayerPrefs.SetInt("Difficulty", difficulty);
        PlayGames();
    }
}
