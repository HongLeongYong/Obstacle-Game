using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // 把相機連接Player的動作，所以需要player的位置
    public Transform player;
    // 不能直接用player的視角，需要保持一定的距離，然後調整三維的參數。
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
