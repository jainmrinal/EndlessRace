using UnityEngine;
using System.Collections;

public class ObstacleScript : MonoBehaviour {
    GameManager gameManager;

    void Start()
    {
        gameManager = GameManager.getInstance();
        GameManager.switchDimension += SwitchRendererState;
    }
    void SwitchRendererState()
    {
        this.gameObject.GetComponent<Renderer>().enabled ^= true;
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided.");
    }
}