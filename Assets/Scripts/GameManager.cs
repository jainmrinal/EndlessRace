using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int a;
    private static GameManager instance = null;
    private GameManager() { }
    public static GameManager getInstance()
    {
        if (instance == null)
        {
            instance = new GameManager();
        }
        return instance;
    }
    public delegate void SwitchDimension();
    public static event SwitchDimension switchDimension;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        switchDimension();
    }

   public void CheckSingleTon()
    {
        a += 5;
    }
}
