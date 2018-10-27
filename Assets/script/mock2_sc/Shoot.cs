using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    [SerializeField] GameObject bullet = null;
    private float shoot_speed = 1000.0f;
    private float shoot_interval = 0f;
    const float max_shoot_interval = 0.25f;
    const float min_shoot_interval = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        shoot_interval -= Time.deltaTime;

        if (Input.GetMouseButton(0))
        {
            if (shoot_interval <= min_shoot_interval ) {
                GameObject new_bullet = Instantiate(bullet, gameObject.transform.position, gameObject.transform.rotation) as GameObject;
                new_bullet.GetComponent<Rigidbody>().AddForce(transform.forward * shoot_speed);
                Destroy(new_bullet, 3f);
                shoot_interval = max_shoot_interval;
            }
        }
	}
}
