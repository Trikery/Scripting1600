using System.Collections;

namespace StudioThorn {
	public class EnumController {
		public enum GamePlay {StartMenu, CharacterSelection, PickCotton, PickSilk};
		public static GamePlay playGame = GamePlay.StartMenu;
	}
}
