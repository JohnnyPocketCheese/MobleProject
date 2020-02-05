using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    public float yMoveSpeed = 0.1f;
    void FixedUpdate ()
    {
        float desiredPosition = target.position.x + offset.x;
        float smoothedPositionX = Mathf.Lerp(transform.position.x, desiredPosition, smoothSpeed);
        transform.position = new Vector3(smoothedPositionX, transform.position.y, transform.position.z);
    }
}
