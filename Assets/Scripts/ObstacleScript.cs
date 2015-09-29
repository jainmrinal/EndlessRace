using UnityEngine;
using System.Collections;

public class ObstacleScript : MonoBehaviour {
    GameManager GM;

    void Start()
    {
        GM = GameManager.getInstance();
        GameManager.switchDimension += SwitchRendererState;
  
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
           GM.CheckSingleTon();
            Debug.Log(GM.a);
        }
    }
    void SwitchRendererState()
    {
        this.gameObject.GetComponent<Renderer>().enabled ^= true;
    }
}