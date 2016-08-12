
public class PlayerStates {

	public enum playerStates {fight, flight};  /*
													determine the player states whether player can be
													killed or not
												*/

	public static playerStates currentPlayerState = playerStates.flight;//initial player state is set to can be killed "flight"

}
