using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour
{
    public string Levelname;
    private float AnimateSpeed = 100;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(Vector3.up, AnimateSpeed * Time.deltaTime);
    }


    private void OnTriggerEnter(Collider other)
    {
        print("Collision");
        if (other.gameObject.tag.Equals("Player")) 
        {
            SceneManager.LoadScene(Levelname);
        }
    }
 
}
