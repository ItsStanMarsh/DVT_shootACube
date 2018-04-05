using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _gameManager : MonoBehaviour {

    public int score = 0;
    public Text text_score;

	public void Score()
    {
        score++;
        text_score.text = "Score = " + score.ToString();

    }

    private void OnTriggerEnter(Collider other)
    {
        Score();
    }
}
