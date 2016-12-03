using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FoodScore : MonoBehaviour {

  public Text scoreText;
	private int healthyF;
	private int unhealthyF;
	private int totalScore;
	private bool answered = false;
	private Timer localGameTimer;

  public void Initialize(Timer gameTimer, int healthyFood, int unhealthyFood) {
	healthyF = healthyFood;
	unhealthyF = unhealthyFood;
		localGameTimer = gameTimer;

   


    GlobalScore.addScore(healthyFood - unhealthyFood);

  }

	// Use this for initialization
	void Start () {
		totalScore = healthyF - unhealthyF;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (TFButton.isCorrect && !answered) {
			totalScore += 5;
			answered = true;
			GlobalScore.addScore (5);
		} 
		scoreText.text = "Time: " + localGameTimer.toString() + "\n" +
			"Healthy Food Grabbed: " + healthyF + "\n" +
			"Unhealthy Food Grabbed: " + unhealthyF + "\n" +
			"Final Score: " + totalScore;			
	}

  void returnToCity() {

    SceneManager.LoadScene(0);

  }
}
