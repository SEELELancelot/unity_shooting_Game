using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private float move_x;
    private float move_z;
    public float speed=1;
    protected Transform m_transform;
    public Transform m_rocket;

    public float can_insert_time;
    private float time=0;
    // Use this for initialization
	void Start () {
        m_transform = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        move_x = 0;
        move_z = 0;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            move_z -= speed*Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            move_z += speed * Time.deltaTime;          
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            move_x += speed * Time.deltaTime;       
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            move_x -= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0))
        {
            if (time >= can_insert_time)
            {
                Instantiate(m_rocket, m_transform.position, m_transform.rotation);
                time = 0;
            }
        }
        m_transform.Translate(new Vector3(move_x, 0, move_z));
    }
}
