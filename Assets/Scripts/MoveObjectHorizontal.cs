using UnityEngine;

public class MoveObjectHorizontal : MonoBehaviour
{
    public float moveSpeed = 2f;  // 移动速度
    public float moveRange = 2f;  // 左右移动的范围
    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        float newXPosition = Mathf.Sin(Time.time * moveSpeed) * moveRange;
        transform.position = new Vector3(initialPosition.x + newXPosition, initialPosition.y, initialPosition.z);
    }
}
