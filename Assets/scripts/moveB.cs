using UnityEngine;
using System.Collections;

public class moveB : MonoBehaviour {
	
	public float speed;
	private Rigidbody rb;
    public GameObject gameOver;
	
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("HorizontalB");
		float moveVertical = Input.GetAxis ("VerticalB");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		
		rb.AddForce (movement * speed);
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("killer"))
        {
            Debug.Log("game over B");
            gameOver.SetActive(true);
            Time.timeScale = 0;

        }
    }
}