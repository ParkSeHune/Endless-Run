using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DataManager : MonoBehaviour
{
    public static DataManager instance;
    public int bestScore;
    public int score;
    public int level = 1;
    public TextMeshProUGUI bestScoreGUI;
    public TextMeshProUGUI scoreGUI;
    public TextMeshProUGUI levelGUI;

    float timer = 0.0f;

    void Start()
    {
        level = 1;
        instance = this;
        bestScore = PlayerPrefs.GetInt("BestScore");
    }

    public void Save()
    {
        if (score >= bestScore)
        {
            bestScore = score;
        }

        PlayerPrefs.SetInt("BestScore", bestScore);
    }

    void Update()
    {
        if (GameManager.instance.condition == false)
        {
            return;
        }

        timer += Time.deltaTime;

        if (timer >= 1.0f)
        {
            switch (level)
            {
                case 1:
                    score += 1;
                    break;
                case 2:
                    score += 2;
                    break;
                case 3:
                    score += 3;
                    break;
            }
            timer = 0.0f;
        }

        bestScoreGUI.text = "Best Score : " + bestScore.ToString();
        scoreGUI.text = "Score : " + score.ToString();
        levelGUI.text = "Level" + level.ToString();
    }
}
