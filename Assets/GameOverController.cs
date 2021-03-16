using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour {

    public Text ScoreText;
    public static PlayerScore score;

	// Use this for initialization
	void Start () {
        score = FindObjectOfType<PlayerScore>();
        ScoreText.text = "Score: " + (int)score.playerScore;
	}
}
