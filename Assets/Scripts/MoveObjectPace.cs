using UnityEngine;

public class MoveObjectPace : MonoBehaviour
{
    public float speed = 2f;
    public float height = 2f;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        // 使用 Mathf.Pow 让物体的上下移动有先慢后快的效果
        float timeFactor = Mathf.Pow(Time.time, 1.5f); // 指数 1.5 使时间加速变化
        float newY = Mathf.Sin(timeFactor * speed) * height;

        transform.position = new Vector3(startPos.x, startPos.y + newY, startPos.z);
    }
}
