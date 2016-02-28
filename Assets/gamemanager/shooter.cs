using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class shooter : MonoBehaviour {

	[SerializeField]
	RawImage ri;

	[SerializeField]
	Texture[] ballTexture = new Texture[3];

	[SerializeField]
	GameObject[] ball = new GameObject[3];	//Ball(GameObject)

	[SerializeField]
	GameObject whiteBall;

	[SerializeField]
	float whiteBallSpeed = 30f;

	[SerializeField]
	float shootSpeed = 30f;

	GameObject currentBall;
	Sprite currentBallImage;

	Rigidbody2D currentBallrb;
	int nextBallIndex;

	void Start () {
		nextBallIndex = Random.Range (0, 3);

		switch (nextBallIndex) {
		case 0:
			ri.texture = ballTexture [0];
			break;
		case 1:
			ri.texture = ballTexture [1];
			break;
		case 2:
			ri.texture = ballTexture [2];
			break;

		}
	}
	
	// Update is called once per frame
	void Update () {
		//currentBallImage. s

		MoveWhiteBall ();

		if (Input.GetButtonUp ("Jump")) {
			Shoot (nextBallIndex);

			//setTexture
			switch (nextBallIndex) {
			case 0:
				ri.texture = ballTexture [0];
				break;
			case 1:
				ri.texture = ballTexture [1];
				break;
			case 2:
				ri.texture = ballTexture [2];
				break;
			}

		}
	}

	void Shoot(int index){
		currentBall = Instantiate (ball [index], whiteBall.transform.position, Quaternion.identity) as GameObject;
		currentBallrb = currentBall.GetComponent<Rigidbody2D>();

		//next Ball index
		nextBallIndex = Random.Range (0, 3);

		currentBallrb.AddForce(new Vector3(0, shootSpeed, 0));
	}

	void MoveWhiteBall(){
		whiteBall.transform.Translate (Input.GetAxisRaw ("Horizontal") * whiteBallSpeed * Time.deltaTime, 0, 0);
	}     
}
