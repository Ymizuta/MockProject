using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonScript : MonoBehaviour {

    const float min_elevation_angle = 0f;
    const float max_elevation_angle = 90f;
    private float canon_evelation_angle;
    private float default_canon_evalation_angle;
    private float add_evelation_angle = -1f;
    private Vector3 canon_angle;

    // Use this for initialization
    void Start () {
        canon_angle = gameObject.transform.rotation.eulerAngles;
    }
	
	// Update is called once per frame
	void Update () {
        canon_angle = gameObject.transform.rotation.eulerAngles;
        canon_evelation_angle =canon_angle.x + add_evelation_angle * Input.GetAxis("Vertical");
        if (canon_evelation_angle <= 315f && canon_evelation_angle >= 180f)
        {
            canon_evelation_angle = 315f;
            Debug.Log(canon_evelation_angle);
        }
        else
        if (canon_evelation_angle < 180f && canon_evelation_angle >= 0f)
        {
            canon_evelation_angle = 0f;
        }
        canon_angle.x = canon_evelation_angle;
        //canon_angle.y = 0f;
        canon_angle.z = 0f;
        gameObject.transform.rotation = Quaternion.Euler(canon_angle);
    }
}
