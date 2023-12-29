using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosePlayer : MonoBehaviour
{
    public RacketPlayer2 racketPlayer2;
    public RacketPlayer2AI racketPlayer2AI;

    void Start()
    {
        int gameMode = PlayerPrefs.GetInt("GameMode");

        if (gameMode == 1)
        {
            SetSinglePlayerMode();
        }
        else if (gameMode == 2)
        {
            SetPlayerVsPlayerMode();
        }
    }

    private void SetSinglePlayerMode()
    {
        racketPlayer2AI.enabled = true;
        Debug.Log("racketPlayer2 is enabled");
    }

    private void SetPlayerVsPlayerMode()
    {
        racketPlayer2.enabled = true;
        Debug.Log("racketPlayer2AI is enabled");
    }         
}
