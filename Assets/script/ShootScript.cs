using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour {

    [SerializeField] GameObject shell_ = null;
    private float shoot_power = 1000.0f;
    private float destroy_time = 3.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject new_shell = Instantiate(shell_, gameObject.transform.position, gameObject.transform.rotation) as GameObject;
            new_shell.GetComponent<Rigidbody>().AddForce(transform.forward * shoot_power);
            Destroy(new_shell, destroy_time);
        }		
	}
}
