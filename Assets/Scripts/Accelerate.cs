using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;
public class Accelerate : MonoBehaviour {

    public float interval = 10.0f;
    public float accelerationInterval = 0;
    public float speed;
    public float sideSpeed;
    private float moveHorizontal;
    private float acceleration;
    public float blurSpeed;
    public GameObject mainCam;
    public int timeLimit;
    private CharacterController controller;
    GameManager gameManager;
    Blur blurscript;
    public Vector3 startPos;
	// Use this for initialization
	void Start () {
		startPos = this.transform.position;
		gameManager = GameManager.getInstance();
		blurscript = mainCam.GetComponent<Blur>();
		GameManager.blurEffects += SwitchOnBlur;
		GameManager.resetApp += ResetPosis;
        controller = this.gameObject.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        acceleration = Mathf.Max(0, Mathf.Sin(Time.time/interval) - ( 1- accelerationInterval));
        speed += (acceleration * Time.deltaTime);
        controller.SimpleMove(this.transform.forward * speed);
			
        moveHorizontal = Input.GetAxis("Horizontal");
        controller.SimpleMove(this.transform.right * moveHorizontal * sideSpeed);
		if(Input.GetKeyDown(KeyCode.LeftControl))
			gameManager.blureffectsOn();
   }
   
   void SwitchOnBlur(){
		
		blurscript.enabled = true;
		StartCoroutine("RemoveBlur");
	
	}
	IEnumerator RemoveBlur(){
	float currentTime = Time.time;
	while(blurscript.iterations<=20){
		
		if(Time.time - currentTime >= 0.01f)
		{
			blurscript.iterations +=2;
			currentTime = Time.time;
		}
			yield return null;
		
		}
		blurscript.enabled = false;
		blurscript.iterations = 0;
		gameManager.ChangeDimension();
	}
	
	void ResetPosis(){
	
		this.transform.position = startPos;
		
	}
   
  }
