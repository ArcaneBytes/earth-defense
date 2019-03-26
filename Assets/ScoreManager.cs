using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public Text text;

    private int score = 0;

    public void increaseScore(int numberToIncrease)
    {
        score += numberToIncrease;
        text.text = score.ToString();
    }

}
