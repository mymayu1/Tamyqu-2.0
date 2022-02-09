using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;

    //public TextMeshProUGUI EScoreText;
    //public TextMeshProUGUI EHighscoreText;

    int score = 0;
    int highscore = 0;
    //int EndScore = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = score.ToString() + " POINTS";
        highscoreText.text = "Highscore: " + highscore.ToString();
        //EScoreText.text = "You've reached " + score.ToString() + " Points";
        //highscoreText.text = "Highscore: " + highscore.ToString();
        //EHighscoreText.text = "Highscore: " + highscore.ToString();

    }

    public void AddDeadPoint()
    {
        score += 10;
        scoreText.text = score.ToString() + " POINTS";
        //EScoreText.text = "You've reached " + score.ToString() + " Points";

        PlayerPrefs.SetInt("highscore", score);
        if (highscore < score)
            PlayerPrefs.SetInt("highscore", score);
    }
    public void AddPoint()
    {
        score += 5;
        scoreText.text = score.ToString() + " POINTS";
        //EScoreText.text = "You've reached " + score.ToString() + " Points";

    }
    public void MinusPoint()
    {
        if (score > 0)
        {
            score -= 5;
            scoreText.text = score.ToString() + " POINTS";
            //EScoreText.text = "You've reached " + score.ToString() + " Points";
        }
    }

    public void deleteInt()
    {
        PlayerPrefs.DeleteKey("highscore"); // delete data
    }
}
