using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // 連接於Unity 的 Rigidbody 變數，讓物體有物理原理
    public Rigidbody rb;

    // Unity 中，Player前進的力量
    public float forwardForce = 2000f;

    // Player左右移動的力量
    public float sidewaysForce = 500f;

    // 改名"Fixed"Update, 原因是因為有使用到物理的變量
    void FixedUpdate()
    {
        // 加推進力，讓Player前進
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // Player向右移動
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // Player向左移動
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // 如果Player移動掉下平台後，就呼叫GameManager中的EndGame()
        if (rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
