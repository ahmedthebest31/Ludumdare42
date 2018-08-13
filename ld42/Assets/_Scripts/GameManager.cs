using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    [SerializeField] Image helthImage;
    [SerializeField] Text scoreText;

    public static GameManager instance;

    [HideInInspector]public int anemyCound = 0;
    [HideInInspector]public int score = 0;

    private void Start()
    {
        instance = this;
        helthImage.type = Image.Type.Filled;
        helthImage.fillMethod = Image.FillMethod.Horizontal;
        //helthImage.fillOrigin = -1;
        helthImage.fillAmount = 0f;
          
        
    }
    private void Update()
    {
        if (anemyCound >= 10)
            GameOver();

        scoreText.text = "score: " + score;
        helthImage.fillAmount = anemyCound / 10f;
    }

    private void GameOver()
    {
        //Debug.Log("game over");
        PlayerPrefs.SetInt("Score", score);
        SceneManager.LoadScene("GameOver");
    }
} // end class