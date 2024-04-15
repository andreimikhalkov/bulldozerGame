using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int score;

    private void Start()
    {
        score = 0;
    }

    public void IncrementScore()
    {
        score++;
        Debug.Log("¬аш счет: " + score);
    }
}
