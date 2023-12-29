using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public BallMovement ballMovement;
    public ScoreIncrease scoreIncrease;
    public RacketPlayer1 racketPlayer1;
    public RacketPlayer2 racketPlayer2;
    TrailRenderer trailRenderer;

    private void Start()
    {
        trailRenderer = GetComponent<TrailRenderer>();
        trailRenderer.enabled = true;
    }

    void BounceFromRacket(Collision2D c)
    {

        Vector3 ballPosition = this.transform.position;
        Vector3 racketPosition = c.gameObject.transform.position;

        float racketHeight = c.collider.bounds.size.y;

        float x;

        if (c.gameObject.name == "RacketPlayer1")
        {
            x = 1;
        }
        else
        {
            x = -1;
        }

        float y = (ballPosition.y -  racketPosition.y) / racketHeight;

        this.ballMovement.IncreaseHitCounter();
        this.ballMovement.moveBall(new Vector2(x, y));

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "RacketPlayer1" || collision.gameObject.name == "RacketPlayer2")
                {
            this.BounceFromRacket(collision);
        }
        else if(collision.gameObject.name == "Left")
        {
            Debug.Log("Collision with left wall");
            this.scoreIncrease.GoalPlayer2();
            StartCoroutine(this.ballMovement.StartBall(true));

            this.racketPlayer1.ResetRacketPosition();
            this.racketPlayer2.ResetRacketPosition();

            trailRenderer.enabled = false;
        }
        else if (collision.gameObject.name == "Right")
        {
            Debug.Log("Collision with right wall");
            this.scoreIncrease.GoalPlayer1();

            StartCoroutine(this.ballMovement.StartBall(false));

            this.racketPlayer1.ResetRacketPosition();
            this.racketPlayer2.ResetRacketPosition();

            trailRenderer.enabled = false;
        }
    }
}