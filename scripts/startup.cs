using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startup : MonoBehaviour {

    //public Object movingCam;

    // Use this for initialization

    public GameObject ready;
    public GameObject go;

	void Start () {

        ready.SetActive(true);
        StartCoroutine(Go());
        Time.timeScale = 0;
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    IEnumerator Go()
    {
        yield return new WaitForSecondsRealtime(4);
        ready.SetActive(false);
        go.SetActive(true);
        Time.timeScale = 1;
        yield return new WaitForSecondsRealtime(1);
        go.SetActive(false);
    }

}
