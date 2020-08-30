using UnityEngine;

namespace Util
{
    public static class PlayerPrefManager
    {
	    public static int GetScore(int levelNumber) {
			if (PlayerPrefs.HasKey("l" + levelNumber)) {
				return PlayerPrefs.GetInt("l" + levelNumber);
			}

			return 0;
	    }

	    public static void ResetLevelScores()
	    {
		    for (int i = 1; i <= 6; i++)
		    {
			    PlayerPrefs.SetInt("l" + i, 0);
		    }
	    }

	    // story the current player state info into PlayerPrefs
	    public static void SavePlayerState(int score, int levelNumber) {
		    PlayerPrefs.SetInt("l" + levelNumber, score);
	    }
	
	    // output the defined Player Prefs to the console
	    public static void ShowPlayerPrefs() {
		    // store the PlayerPref keys to output to the console
		    string[] values = {"l1", "l2", "l3", "l4", "l5", "l6"};

		    // loop over the values and output to the console
		    foreach(string value in values) {
			    if (PlayerPrefs.HasKey(value)) {
				    Debug.Log (value + " = " + PlayerPrefs.GetInt(value));
			    } else {
				    Debug.Log (value+" is not set.");
			    }
		    }
	    }
    }
}