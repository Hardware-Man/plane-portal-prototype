using UnityEngine;

public class RotateObject : MonoBehaviour
{
    // 控制旋转速度的变量
    public float rotationSpeed = 100f;

    // 每帧都会调用此方法
    void Update()
    {
        // 使用 Time.deltaTime 保持旋转速率与帧率无关
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
