using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // playermovement 是player 運動的方式（另外一個.cs)
    public PlayerMovement movement;

    // GameManager 就是要控制遊戲勝負的東西（另外一個.cs)
    // 這個寫法不大好，原因是因為，如果player不小心被刪除了，那麼連接就會斷掉
    /*public GameManager gameManager;*/

    private void OnCollisionEnter(Collision collision)
    {
        // 顯示出目前撞到了什麼東西的名稱
        /*Debug.Log("你撞到了" + collision.collider.name);*/

        if (collision.collider.tag == "Obstacle")
        {
            // 如果撞到障礙物、那麼物體將不會動
            movement.enabled = false;
            // 如果撞到障礙物後，就會呼叫GameManager中的 EndGame，然後結束遊戲
            FindObjectOfType<GameManager>().EndGame();

        }

    }
}
