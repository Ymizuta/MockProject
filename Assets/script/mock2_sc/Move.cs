using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    private Vector3 player_poz;
    private float player_move_speed = 0.1f;
    private float player_move_speed_z = 0.1f;

    // Use this for initialization
    void Start () {
        player_poz = gameObject.transform.position;	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical")) {
            player_poz.x += Input.GetAxis("Horizontal") * player_move_speed;
            //player_poz.z += Input.GetAxis("Vertical") * player_move_speed;
            gameObject.transform.position = player_poz;
        }
        
        player_poz.z += player_move_speed_z;
        gameObject.transform.position = player_poz;

    }
}
