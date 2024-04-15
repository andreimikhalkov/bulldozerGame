using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddOnDestroy : MonoBehaviour
{
    private ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void OnDestroy()
    {
        if (scoreManager != null)
        {
            scoreManager.IncrementScore();
        }
    }
}
