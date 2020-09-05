using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Util
{
    public class GameManager : MonoBehaviour
    {
		// static reference to game manager so can be called from other scripts directly (not just through gameobject component)
		public static GameManager gm;

		// levels to move to on victory and lose
		public string levelAfterVictory;
		public string levelAfterGameOver;

		// game performance
		public int score = 0;
		public int currentGameLevel;

		// UI elements to control
		public Text UIScore;

		// private variables
		GameObject _player;
		Scene _scene;
		
		// Audio Source
		public AudioSource AudioSource
		{
			get;
			set;
		}

		// set things up here
		void Awake () {
			// setup reference to game manager
			if (gm == null)
				gm = this.GetComponent<GameManager>();

			// setup all the variables, the UI, and provide errors if things not setup properly.
			setupDefaults();
			
			AudioSource = GetComponent<AudioSource>();
		}

		// setup all the variables, the UI, and provide errors if things not setup properly.
		void setupDefaults() {
			// setup reference to player
			if (_player == null)
				_player = GameObject.FindGameObjectWithTag("Player");
			
			if (_player==null)
				Debug.LogError("Player not found in Game Manager");

			// get current scene
			_scene = SceneManager.GetActiveScene();

			// if levels not specified, default to current level
			if (levelAfterVictory=="") {
				Debug.LogWarning("levelAfterVictory not specified, defaulted to current level");
				levelAfterVictory = _scene.name;
			}
			
			if (levelAfterGameOver=="") {
				Debug.LogWarning("levelAfterGameOver not specified, defaulted to current level");
				levelAfterGameOver = _scene.name;
			}

			// friendly error messages
			if (UIScore==null)
				Debug.LogError ("Need to set UIScore on Game Manager.");
			
			// get the UI ready for the game
			refreshGUI();
		}

		// refresh all the GUI elements
		void refreshGUI() {
			// set the text elements of the UI
			UIScore.text = "Score: "+score.ToString();
		}

		// public function to add points and update the gui and highscore player prefs accordingly
		public void AddPoints(int amount)
		{
			// increase score
			score+=amount;

			// update UI
			UIScore.text = "Score: " + score.ToString();
		}

	// public function to remove player life and reset game accordingly
		public void ResetGame() {
			// remove life and update GUI
			refreshGUI();
		}

	// public function for level complete
		public void LevelCompete(int levelNumber) {
			// save the current player prefs before moving to the next level
			Debug.Log("Finishing score is: " + score);
			PlayerPrefManager.SavePlayerState(score, levelNumber);
			
			// use a coroutine to allow the player to get fanfare before moving to next level
			StartCoroutine(LoadNextLevel());
		}

		// load the nextLevel after delay
		IEnumerator LoadNextLevel() {
			yield return new WaitForSeconds(3.5f);
			Debug.Log("Scene after victory: " + levelAfterVictory);
			SceneManager.LoadScene(levelAfterVictory);
		}
    }
}