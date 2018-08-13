using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    [SerializeField]Text  scoreText;
    int score, highScore;
    private void Start()
    {
        score = PlayerPrefs.GetInt("Score");
        if (PlayerPrefs.HasKey("HighScore"))
        {
            if (score > PlayerPrefs.GetInt("HighScore") )
            {
                highScore = score;
                PlayerPrefs.SetInt("HighScore", highScore);
            }
            else
            {
                highScore = PlayerPrefs.GetInt("HighScore");
                score = PlayerPrefs.GetInt("Score");
            }
        }
        else
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
        }

        scoreText.text = "score = " + score + "\n" + "high score = "+ highScore; 
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.R))
            SceneManager.LoadScene("Game");

        else if (Input.GetKey(KeyCode.B))
            SceneManager.LoadScene("MainMenue");

    }


} // end class