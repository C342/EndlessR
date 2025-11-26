using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text highscoreText;

    int score = 0;
    int highscore = 0;

    private void Start()
    {
        scoreText.text = score.ToString() + "POINTS";
        highscoreText.text = "HIGHSCORE : " + highscore.ToString();
    }
}