using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGames()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ShowCredits()
    {
        SceneManager.LoadScene(3);
    }

    public void ShowInstructions()
    {
        SceneManager.LoadScene(3);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
