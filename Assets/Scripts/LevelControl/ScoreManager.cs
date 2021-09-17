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

    
    private void Start()
    {
        //checks the player prefs to see if thigh score field exists otherwise it will set highscore to 0
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScoreCount = PlayerPrefs.GetFloat("HighScore");
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
            PlayerPrefs.SetFloat("HighScore", highScoreCount);
        }

        //adding the numbers to the textfields
        scoreText.text = "" + Mathf.Round(scoreCount);
        highScoreText.text = "High Score: " + Mathf.Round(highScoreCount);

    }



}
