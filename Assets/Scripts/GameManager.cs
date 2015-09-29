using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager gameInstance = null;
    private GameManager() { }
    public static GameManager getInstance()
    {
        if (gameInstance == null)
        {
            gameInstance = new GameManager();
        }

        return gameInstance;
    }

    public delegate void SwitchDimension();
    public static event SwitchDimension switchDimension;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
            switchDimension();
    }
}
