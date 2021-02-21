using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        // 連接到GameManager中的CompleteLevel, 告訴遊戲，通過了這個東西後等級就完成了。
        FindObjectOfType<GameManager>().CompleteLevel();
    }
}
