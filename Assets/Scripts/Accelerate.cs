using UnityEngine;
using System.Collections;

public class Accelerate : MonoBehaviour {

    public float interval = 10.0f;
    public float accelerationInterval = 0;

    public float speed;
    public float sideSpeed;
    private float moveHorizontal;
    private float acceleration;
    private CharacterController controller;
	// Use this for initialization
	void Start () {
        controller = this.gameObject.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        acceleration = Mathf.Max(0, Mathf.Sin(Time.time/interval) - ( 1- accelerationInterval));
        speed += (acceleration * Time.deltaTime);
        controller.SimpleMove(this.transform.forward * speed);

        moveHorizontal = Input.GetAxis("Horizontal");
        controller.SimpleMove(this.transform.right * moveHorizontal * sideSpeed);
   }
}
