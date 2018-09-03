using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket : MonoBehaviour {
    public float rocket_speed=-1;
    public float rocket_life_time=3;
    public float rocket_power = 1;
    protected Transform m_transform;
	// Use this for initialization
	void Start () {
        m_transform = this.transform;
        Destroy(this.gameObject,rocket_life_time);
	}
	
	// Update is called once per frame
	void Update () {
        m_transform.Translate(new Vector3(0,0,rocket_speed*Time.deltaTime));
	}
}
