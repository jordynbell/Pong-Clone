using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketPlayer1 : MonoBehaviour
{

    public float movementSpeed;

    public void ResetRacketPosition()
    {
        Vector3 newPosition = new Vector3(-550, 0, 1);
        transform.position = newPosition;
    }

    private void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical1");

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * movementSpeed;
    }
}
