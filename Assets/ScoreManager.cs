using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    int peopleOnBoard;

    public Text peopleOnBoardText;
    public Text peopleSavedText;

    private int peopleSaved = 0;
    void Update()
    {
        if (peopleOnBoard < 1000)
        {
            peopleOnBoard += Random.Range(2, 4);
            peopleOnBoardText.text = peopleOnBoard.ToString();
        }
        else
        {
            increaseScore(peopleOnBoard);
            peopleOnBoard = 0;
            peopleOnBoardText.text = peopleOnBoard.ToString();
        }
    }
    public void increaseScore(int numberToIncrease)
    {
        peopleSaved += numberToIncrease;
        peopleSavedText.text = peopleSaved.ToString();
    }

}
