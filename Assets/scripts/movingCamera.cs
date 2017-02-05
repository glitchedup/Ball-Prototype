using UnityEngine;
using System.Collections;

public class movingCamera : MonoBehaviour {

	public float speed;



	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        
		transform.Translate(0.0f,speed,0.0f);
	}


}
