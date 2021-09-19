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
        easyText.text = Mathf.Round(PlayerPrefs.GetFloat("HighScoreEasy")).ToString();
        mediumText.text = Mathf.Round(PlayerPrefs.GetFloat("HighScoreMedium")).ToString();
        hardText.text = Mathf.Round(PlayerPrefs.GetFloat("HighScoreHard")).ToString();
        progamerText.text = Mathf.Round(PlayerPrefs.GetFloat("HighScoreProGamer")).ToString();
    }
}
