using UnityEngine;

public class MoveLeftRight : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of the movement
    public float distance = 5f; // Distance to move left and right
    private Vector3 startPosition;
    private Vector3 targetPosition;
    private bool movingRight = true;

    void Start()
    {
        startPosition = transform.position;
        targetPosition = startPosition + new Vector3(distance, 0, 0); // Move along the X axis
    }

    void Update()
    {
        if (movingRight)
        {
            // Move towards the target position to the right
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            // Check if we've reached the target position
            if (transform.position == targetPosition)
            {
                movingRight = false; // Change direction to left
            }
        }
        else
        {
            // Move back to the start position
            transform.position = Vector3.MoveTowards(transform.position, startPosition, moveSpeed * Time.deltaTime);

            // Check if we've reached the start position
            if (transform.position == startPosition)
            {
                movingRight = true; // Change direction to right
            }
        }
    }
}
