using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_Tracker : MonoBehaviour
{
    public int romantic, friendly, sexual, strikes;

    public void romanticScore(int x)
    {
        romantic += x;
    }
    public void friendlyScore(int x)
    {
        friendly += x;
    }

    public void sexualScore(int x)
    {
        sexual += x;
        takeStrike(x);
    }
    public void takeStrike(int x)
    {
        strikes += x;
    }
    void Update()
    {
        if (strikes >=3)
        {
            gameOver();
        }
    }
    public void gameOver()
    {

    }
}
