using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class highScore : MonoBehaviour
{
    public Text highScoreText;

    // Start is called before the first frame update
    void Start()
    {
        highScoreText.text = "HIGH SCORE: " + PlayerPrefs.GetInt("highscore");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
