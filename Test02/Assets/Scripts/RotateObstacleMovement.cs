using UnityEngine;

public class RotateObstacleMovement : MonoBehaviour
{
    public float turnSpeed = 100f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
    }
}
