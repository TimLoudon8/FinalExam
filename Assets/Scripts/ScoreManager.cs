using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int score = 0;

    public GameObject scoreCount;
    TextMeshProUGUI scoreCountText;

    private void Awake()
    {
        if(!instance)
        {
            instance = this;
        }

        scoreCountText = scoreCount.GetComponent<TextMeshProUGUI>();
    }

    public void AddScore(int num)
    {
        score += num;
    }

    private void Update()
    {
        scoreCountText.text = "Score: " + score;
    }
}
