using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ballmanage : MonoBehaviour {

	public GameObject bh;
	public score Score;//scoreのパブリック変数
	public float accelerationScale;
	public int destroycounter;
	public string colortag;
	public List<Collider2D> collisionontacts = new List<Collider2D>();
		
		// Use this for initialization
		void Awake () {
		//Score = gameObject.transform.Find ("Text").GetComponent<score> ();
		}
		
		// Update is called once per frame
		void Update () {
			if (collisionontacts.Count >= destroycounter) {
			//Score.SendMessage ("ScoreUp", 1);
			Destroy(gameObject);
			//Score(GUIText)のScoreUpメソッドを呼び出す
			}

	}
	
		void FixedUpdate(){
			var direction = bh.transform.position - transform.position;
			direction.Normalize ();
			this.gameObject.GetComponent<Rigidbody2D> ().AddForce (accelerationScale * direction, ForceMode2D.Force);
			
			
			// Rigidbody.AddForce (accelerationScale * direction, ForceMode.Acceleration);
		}
		
		void OnCollisionEnter2D (Collision2D col){
			if (col.gameObject.tag == colortag) {
				if(!collisionontacts.Contains(col.collider)){
					collisionontacts.Add(col.collider);
				}
			}
		}
		
		void OnCollisionExit2D (Collision2D col){
			if (col.gameObject.tag == colortag) {
				if(collisionontacts.Contains(col.collider)){
					collisionontacts.Remove(col.collider);
				}
			}
		}
}
