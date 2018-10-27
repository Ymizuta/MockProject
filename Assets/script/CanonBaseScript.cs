using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonBaseScript : MonoBehaviour {
    private Vector3 canon_base_angle;
    private float canon_horizon_angle;
    private float add_canon_base_angle = 1f;
    const float max_horizontal_angle = 45f;
    const float min_horizontal_angle = -45f;

    // Use this for initialization
    void Start () {
        canon_base_angle = gameObject.transform.rotation.eulerAngles;
	}
	
	// Update is called once per frame
	void Update () {
        canon_horizon_angle = canon_base_angle.y + add_canon_base_angle * Input.GetAxis("Horizontal");
        if (canon_horizon_angle >=max_horizontal_angle)
        {
            //Debug.Log(canon_horizon_angle);
            canon_horizon_angle = max_horizontal_angle;
        }else
        if (canon_horizon_angle <= min_horizontal_angle)
        {
            //Debug.Log(canon_horizon_angle);
            canon_horizon_angle = min_horizontal_angle;
        }
        canon_base_angle.y = canon_horizon_angle;
        canon_base_angle.x = 0;
        canon_base_angle.z = 0;
        gameObject.transform.rotation = Quaternion.Euler(canon_base_angle);
    }
}
