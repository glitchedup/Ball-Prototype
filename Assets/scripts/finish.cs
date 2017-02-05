using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : MonoBehaviour {
    private bool levelEnd = false;
    public GameObject youWin;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            Debug.Log("Love!");
            levelEnd = true;
            LevelClear();
            
        }
    }

    void LevelClear()
    {
        Debug.Log("You win!");
        youWin.SetActive(true);

    }


}
