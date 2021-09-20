using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    private int difficulty;

    // Start is called before the first frame update
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    private void PlayGames()
    {
        SceneManager.LoadScene(1);
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
