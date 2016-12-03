using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;




public class Quiz : MonoBehaviour {


	public Text question;
	public static bool answer;


	void Start() {
		MeshRenderer m = this.GetComponent<MeshRenderer>();
		m.enabled = true;




		switch(NutritionFacts.quizChosen) {


		case 1:
			question.text = "Carrots are a good source of cholesterol\n";
			answer = false;
			break;


		case 2:
			question.text = "TPizza is a good source of potassium";
			answer = false;
			break;


		case 3:
			question.text = "True or false?\nRipe bananas are mostly starch";
			answer = false;
			break;


		case 4:
			question.text = "True or false?\nUnripe bananas are mostly sugars\n";
			answer = false;
			break;


		case 5:
			question.text = "True or false?\nIt is good to eat a lot of ice cream everyday.";
			answer = false;
			break;


		case 6:
			question.text = "True or false?\nBroccoli does not provide a good source of water.";
			answer = false;
			break;


		case 7:
			question.text = "True or false?\nBroccoli in not a good source of fiber";
			answer = false;
			break;


		case 8:
			question.text = "True or false?\nBroccoli is not a good source of vitamin C\n";
			answer = false;
			break;


		case 9:
			question.text = "True or false?\nBroccoli is not a good source of vitamin K\n";
			answer = false;
			break;


		case 10:
			question.text = "True or false?\nBurgers are not high in protein\n";
			answer = false;
			break;


		case 11:
			question.text = "True or false?\nEating a lot of pizza will lead to a healthy life";
			answer = false;
			break;


		case 12:
			question.text = "True or false?\nFiber can increase risk of disease";
			answer = false;
			break;


		case 13:
			question.text = "True or false?\nHigh amounts of cholesterol will lead to a healthy life\n";
			answer = false;
			break;


		case 14:
			question.text = "True or false?\nPotassium is not found in bananas";
			answer = false;
			break;


		case 15:
			question.text = "True or false?\nCarrots are good for hearing. ";
			answer = false;
			break;


		default:
			break;
		}




	} 


}




