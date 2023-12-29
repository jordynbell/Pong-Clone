using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    public float movementSpeed;
    public float speedIncrease;
    public float maxSpeed;

    int hitCounter = 0;
    TrailRenderer trailRenderer;

    // Start is called before the first frame update
    void Start()
    {
        trailRenderer = GetComponent<TrailRenderer>();
        StartCoroutine(this.StartBall());
    }

    public void PositionBall(bool isStartingPlayer1)
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        
        if (isStartingPlayer1)
        {
            this.gameObject.transform.localPosition = new Vector3(-100, 0, 0);
        }
        else
        {
            this.gameObject.transform.localPosition = new Vector3(100, 0, 0);
        }
    }

    public IEnumerator StartBall(bool isStartingPlayer1 = true)
    {
        this.PositionBall(isStartingPlayer1);

        this.hitCounter = 0;
        yield return new WaitForSeconds(2);
        if (isStartingPlayer1)
            this.moveBall(new Vector2(-1, 0));
        else
        {
            this.moveBall(new Vector2(1, 0));
        }

        trailRenderer.enabled = true;
    }

    public void moveBall(Vector2 dir)
    {
        dir = dir.normalized;

        float speed = this.movementSpeed + this.hitCounter * this.speedIncrease;

        Rigidbody2D rigidBody2D = this.gameObject.GetComponent<Rigidbody2D>();

        rigidBody2D.velocity = dir * speed;
    }

    public void IncreaseHitCounter()
    {
            if (this.hitCounter * this.speedIncrease <= this.maxSpeed)
        {
            this.hitCounter++;
        }
    }

}
