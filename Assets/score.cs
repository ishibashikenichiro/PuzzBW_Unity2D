using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score : MonoBehaviour {
	//スコア
	private int Score = 0;

	// Use this for initialization
	void Start () {
		GetComponent<Text>().text = "SCORE: " + Score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ScoreUp (int point)
	{
		Score += point;
		GetComponent<Text> ().text = "SCORE: " + Score.ToString ();
	}
}
