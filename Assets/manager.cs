using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;
using UnityEngine.UI;

public class manager : MonoBehaviour {
	public GameObject wball;
	public GameObject gball;
	public GameObject bball;


	//	カウント
	public class Count{
		public int minimum;
		public int maximum;

		public Count(int min, int max){
			minimum = min;
			maximum = max;
		}
	}



	// Use this for initialization
	void Start () {
		for(int i = 0 ;i <= 10; i++){
			Instantiate (wball,new Vector2(Random.Range(-100,100),Random.Range(-100,100)),Quaternion.identity);
			Instantiate (gball,new Vector2(Random.Range(-100,100),Random.Range(-100,100)),Quaternion.identity);
			Instantiate (bball,new Vector2(Random.Range(-100,100),Random.Range(-100,100)),Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
