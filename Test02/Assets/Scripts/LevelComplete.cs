using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel()
    {
        // 需要使用SceneManagement
        //通過 SceneManager,加載目前的Scene，然後轉跳到下一個Scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
