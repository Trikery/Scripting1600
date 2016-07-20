
public class GameState {

	//this will change the mode of the game to playing in
	public enum States {Loading, Starting, Playing, Ending};
	//Use to change states in other scripts
	public static States currentGameState = States.Loading;

}
