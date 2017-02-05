using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class restart : MonoBehaviour {



	// Use this for initialization
	void Start () 
    {
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetButtonDown ("restart"))
        {
            Restart();
        }
	}
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("restart!");
        Time.timeScale = 1;
        
    }

}



