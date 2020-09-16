using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Util
{
    public class GameManager : MonoBehaviour
    {
		public static GameManager gm;

		public string levelAfterVictory;
		public string levelAfterGameOver;

		public int score = 0;
		public int currentGameLevel;

		public Text UIScore;

		GameObject _player;
		Scene _scene;
		
		public AudioSource AudioSource
		{
			get;
			set;
		}

		void Awake () {
			if (gm == null)
				gm = this.GetComponent<GameManager>();

			setupDefaults();
			
			AudioSource = GetComponent<AudioSource>();
		}

		void setupDefaults() {
			if (_player == null)
				_player = GameObject.FindGameObjectWithTag("Player");
			
			if (_player==null)
				Debug.LogError("Player not found in Game Manager");

			_scene = SceneManager.GetActiveScene();

			if (levelAfterVictory=="") {
				Debug.LogWarning("levelAfterVictory not specified, defaulted to current level");
				levelAfterVictory = _scene.name;
			}
			
			if (levelAfterGameOver=="") {
				Debug.LogWarning("levelAfterGameOver not specified, defaulted to current level");
				levelAfterGameOver = _scene.name;
			}

			if (UIScore==null)
				Debug.LogError ("Need to set UIScore on Game Manager.");
		}


		public void AddPoints(int amount)
		{
			// TODO: Not researched case: score is multiplied
			if (amount == 8) score+=amount / 4;
			if (amount == 2) score+=amount / 2;
			if (amount == 4) score+=amount / 2;

			if (amount == -2) score+=amount / 2;
			if (amount == -4) score+=amount / 2;
			if (amount == -8) score+=amount / 2;
			
			UIScore.text = "Score: " + score.ToString();
		}

		public void LevelCompete(int levelNumber) {
			// Check whether to save new score or not
			Debug.Log("Finishing score is: " + score);
			
			if (score > PlayerPrefs.GetInt("EarnedScoreForLoadedLevel"))
			{
				PlayerPrefManager.SavePlayerState(score, levelNumber);
			}
			else
			{
				PlayerPrefManager.SavePlayerState(PlayerPrefs.GetInt("EarnedScoreForLoadedLevel"), levelNumber);
			}
			
			StartCoroutine(LoadNextLevel());
		}

		// load the nextLevel after delay
		IEnumerator LoadNextLevel() {
			yield return new WaitForSeconds(2.5f);
			Debug.Log("Scene after victory: " + levelAfterVictory);
			SceneManager.LoadScene(levelAfterVictory);
		}
    }
}