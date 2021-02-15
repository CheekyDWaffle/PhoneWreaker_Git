using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_Tracker : MonoBehaviour
{
    public int score, strikes;

    public void changeScore(int x)
    {
        score += x;
    }
    public void takeStrike()
    {

    }
    void Update()
    {
        if (score >=3)
        {
            gameOver();
        }
    }
    public void gameOver()
    {

    }
}
