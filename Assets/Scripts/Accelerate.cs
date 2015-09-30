using UnityEngine;
using System.Collections;

public class Accelerate : MonoBehaviour {

    public float interval = 10.0f;
    public float accelerationInterval = 0;

    private float acceleration = 1;
    private float Speed = 10.0f;
    private CharacterController controller;
	// Use this for initialization
	void Start () {
        controller = this.gameObject.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        acceleration = Mathf.Max(0, Mathf.Sin(Time.time/interval) - ( 1- accelerationInterval));
        Speed += (acceleration * Time.deltaTime);
        controller.SimpleMove(this.transform.forward * Speed);
	}
}
