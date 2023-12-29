using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreIncrease : MonoBehaviour
{

    private int scorePlayer1 = 0;
    private int scorePlayer2 = 0;

    public GameObject scoreTextPlayer1;
    public GameObject scoreTextPlayer2;

    public int goalToWin;

    private void Update()
    {
        if (this.scorePlayer1 == this.goalToWin || this.scorePlayer2 == this.goalToWin)
        {
            Debug.Log("Game won!");
            SceneManager.LoadScene(2);
        }

    }
    private void FixedUpdate()
    {
        TextMeshProUGUI uiScorePlayer1 = this.scoreTextPlayer1.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI uiScorePlayer2 = this.scoreTextPlayer2.GetComponent<TextMeshProUGUI>();

        uiScorePlayer1.text = this.scorePlayer1.ToString();
        uiScorePlayer2.text = this.scorePlayer2.ToString();
    }

    public void GoalPlayer1()
    {
        this.scorePlayer1++;
    }

    public void GoalPlayer2()
    {
        this.scorePlayer2++;
    }

}
