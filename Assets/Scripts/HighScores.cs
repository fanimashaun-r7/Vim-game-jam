using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScores : MonoBehaviour
{
    public Text easyText;
    public Text mediumText;
    public Text hardText;
    public Text progamerText;

    // Start is called before the first frame update
    void Start()
    {
        easyText.text = "Easy Score: " + Mathf.Round(PlayerPrefs.GetFloat("HighScoreEasy"));
        mediumText.text = "Medium Score: " + Mathf.Round(PlayerPrefs.GetFloat("HighScoreMedium"));
        hardText.text = "Hard Score: " + Mathf.Round(PlayerPrefs.GetFloat("HighScoreHard"));
        progamerText.text = "Pro-gamer Score: " + Mathf.Round(PlayerPrefs.GetFloat("HighScoreProGamer"));
    }
}
