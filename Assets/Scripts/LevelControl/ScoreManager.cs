using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;

    public float scoreCount;
    public float highScoreCount;

    public float pointsPerSecond;

    public bool isDead;

    public int difficulty;
    
    private void Start()
    {
        difficulty = PlayerPrefs.GetInt("Difficulty");

        //checks the player prefs to see if thigh score field exists otherwise it will set highscore to 0
        if (difficulty == 1)
        {
            if (PlayerPrefs.HasKey("HighScoreEasy"))
            {
                highScoreCount = PlayerPrefs.GetFloat("HighScoreEasy");
            }
        }
        if (difficulty == 2)
        {
            if (PlayerPrefs.HasKey("HighScoreMedium"))
            {
                highScoreCount = PlayerPrefs.GetFloat("HighScoreMedium");
            }
        }
        if (difficulty == 3)
        {
            if (PlayerPrefs.HasKey("HighScoreHard"))
            {
                highScoreCount = PlayerPrefs.GetFloat("HighScoreHard");
            }
        }
        if (difficulty == 4)
        {
            if (PlayerPrefs.HasKey("HighScoreProGamer"))
            {
                highScoreCount = PlayerPrefs.GetFloat("HighScoreProGamer");
            }
        }

    }

    private void Update()
    {
        //as long as you are not dead increase score by points * time
        if(isDead == false)
        {
            scoreCount += pointsPerSecond * Time.deltaTime;
        }

        //make highscore equal to score when score is greater than highscore
        if(scoreCount > highScoreCount)
        {
            highScoreCount = scoreCount;

            if(difficulty == 1)
            {
                PlayerPrefs.SetFloat("HighScoreEasy", highScoreCount);
            }
            else if (difficulty == 2)
            {
                PlayerPrefs.SetFloat("HighScoreMedium", highScoreCount);
            }
            else if (difficulty == 3)
            {
                PlayerPrefs.SetFloat("HighScoreHard", highScoreCount);
            }
            else if (difficulty == 4)
            {
                PlayerPrefs.SetFloat("HighScoreProGamer", highScoreCount);
            }

        }

        //adding the numbers to the textfields
        scoreText.text = "" + Mathf.Round(scoreCount);
        highScoreText.text = "High Score: " + Mathf.Round(highScoreCount);

    }



}
