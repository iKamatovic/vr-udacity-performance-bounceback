using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public GameManager gameManager;
    private Text text;
    private int score = 0;

	// Use this for initialization
	void Start () {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        text = GetComponentInChildren<Text>();
        SetScore();
    }
	
	// Update is called once per frame
	void Update () {
        if (score != gameManager.score)
        {
            score = gameManager.score;
            SetScore();
        }
	}

    void SetScore() {
        text.text = "Score: " + score.ToString();
    }
}
