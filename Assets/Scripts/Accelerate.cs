using UnityEngine;
using System.Collections;

public class Accelerate : MonoBehaviour {

    public float acceleration = 2.0f;
    public float maxSpeed = 10.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(0, acceleration * Time.deltaTime, 0);
        if (acceleration < maxSpeed)
        {
            acceleration += 1.0f;
        }
	}
}
