using UnityEngine;
using System.Collections;

public class pause : MonoBehaviour {

	public int paused = 0;
    public GameObject pauseSign;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("pause"))
		{
			if (paused == 0)
			{
				Debug.Log ("pause!");
				paused = 1;
                pauseSign.SetActive(true);
				Time.timeScale = 0;
			}
			else if (paused == 1)
			{
				Debug.Log ("unpause!");
				paused = 0;
				Time.timeScale = 1;
                pauseSign.SetActive(false);
			}
		}
}
}