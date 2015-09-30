using UnityEngine;
using System.Collections;

public class Accelerate : MonoBehaviour {

    private float acceleration = 0;
    private float Speed = 10.0f;
    private CharacterController controller;
	// Use this for initialization
	void Start () {
        controller = this.gameObject.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        acceleration = Mathf.Max(0, Mathf.Sin(Time.time/10.0f));
        Speed += (acceleration * Time.deltaTime);
        controller.SimpleMove(this.transform.forward * Speed);
	}
}
