
public class GameState {

	//this will change the mode of the game to playing in
	public enum States {StartingMenu, MenuScreen, Loading, Starting, Playing, GameOver, WinnerEnding};
	//Use to change states in other scripts
	public static States currentGameState = States.StartingMenu;

}
