[System.Serializable]
public class HealthData{

	//this is our players base health data
	public int health;
	public int strength;
	public int speed = 20;
	private int defence = 100;
	public string username;

	public int TakeDownDefence () {
		return defence -= 10;
	}

}
