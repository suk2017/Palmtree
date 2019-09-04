using UnityEngine;

public class CameraMove : MonoBehaviour
{

    public GameObject Target;//追踪目标 主角
    public float Speed = 0.2f;//追踪速度

    private Transform tr;//自己的位置
    private Transform target;//目标的位置

    void Awake()
    {
        tr = this.transform;
        target = Target.transform;
    }

    void Update()
    {
        float x = Mathf.Lerp(tr.position.x, target.position.x, Speed);
        tr.position = new Vector3(x, 0, -10);
    }
}
