using UnityEngine;
using UnityEngine.UI;

public class scoreboard : MonoBehaviour {

    public Text score;
    public Text highScore;


     void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void highscore() {

        int number = 0;
        score.text = "Score: " + score.ToString();


        if(number > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", number);
            highScore.text = number.ToString();
        }
        
	}
	
}
