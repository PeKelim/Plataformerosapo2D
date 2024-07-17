using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUD : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    int score;

    void ScoreUpdate(int scoreAdd)
    {
        Debug.Log("score added");
        score += scoreAdd;
        scoreText.text = "Score: " + score;
    }
    private void OnEnable()
    {
        Collectable.collectableEvent += ScoreUpdate;
    }
    private void OnDisable()
    {
        Collectable.collectableEvent -= ScoreUpdate;
    }
}
