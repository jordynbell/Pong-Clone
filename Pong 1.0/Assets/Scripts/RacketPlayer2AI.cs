using UnityEngine;

public class RacketPlayer2AI : MonoBehaviour
{
    public GameObject ball;
    private float[] Speeds = {1, 2, 2.5f, 3.5f, 5};
    public float movementSpeed;

    public void ResetRacketPosition()
    {
        Vector3 newPosition = new Vector3(550, 0, 1);
        transform.position = newPosition;
    }

    private void Start()
    {
        movementSpeed = Speeds[PlayerPrefs.GetInt("SelectedOption",0)];
        Debug.Log("Current speed is: " + movementSpeed);
    }

    private void FixedUpdate()
    {
        float v = ball.transform.position.y - this.transform.position.y;

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * movementSpeed;
    }
}