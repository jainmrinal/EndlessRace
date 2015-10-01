public class GameManager
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
    
	public delegate void BlurEffects();
	public static event BlurEffects blurEffects;
	
	public delegate void ResetApp();
	public static event ResetApp resetApp;
	
	public void ChangeDimension(){
	
			switchDimension();
		
	}
	public void ResetApplication(){
	
		resetApp();	
	}
	
	public void blureffectsOn(){
	
	blurEffects();
	}
}
