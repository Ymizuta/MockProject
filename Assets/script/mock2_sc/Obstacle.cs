using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {
    [SerializeField] GameObject obstacle = null;
    private float obstacle_life = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Bullet")
        {
            Debug.Log("Hit!");

            obstacle_life--;
        
            if (obstacle_life <= 0)
            {
                Destroy(obstacle);
            }
        }
    }
}
