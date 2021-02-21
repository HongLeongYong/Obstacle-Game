using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // 這個是player頭上的分數的TEXT，所以需要知道Player的位置以獲取z值，然後顯示分數
    public Transform player;
    // 這個需要使用到 UnityEngine.UI 才能改 Text 
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        // 在Text上顯示目前的分數
        scoreText.text = player.position.z.ToString("0");
    }
}
