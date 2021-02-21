using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // 布林變數，記錄目前 遊戲已經結束了嗎？
    bool gameHasEnded = false;
    // 讓RestartGame（）延遲喚醒的時間
    public float restartDelay = 1f;
    // 連接到遊戲中的Panel,CompleteLevel
    public GameObject completeLevelUI;

   public void EndGame()
    {
        // 當遊戲還沒結束時，呼叫EndGame()，遊戲將會結束（防止遊戲因為死掉而一直呼叫EndGame(),而發生多次EndGame())
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            // 重啟遊戲,使用Restart(),但為了延遲喚醒，使用用了Invoke來呼叫
            Invoke("Restart", restartDelay);
            
        }
        
    }

    void Restart()
    {
        // 需要使用UnityEngine.SceneManagement
        // 指定加載Level 01
        /*SceneManager.LoadScene("Level 01");*/

        // 直接或許現在Active是哪一個Scene，不用放名字
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // 通關完成的呼叫
    public void CompleteLevel()
    {
        // 當呼叫CompleteLevel()，CompleteLevelPanel將被呼叫
        completeLevelUI.SetActive(true);
    }

    
    
}
