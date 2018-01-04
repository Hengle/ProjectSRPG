using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

	public static bool GameIsPaused = false;

	public GameObject MainMenuUI;

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Cancel"))
		{
			if (GameIsPaused)
			{
				closeMainMenu();
			}
			else
			{
				openMainMenu();
			}
		}
	}

	void openMainMenu()
	{
		MainMenuUI.SetActive(true);
		Time.timeScale = 0f;
		GameIsPaused = true;
	}

	void closeMainMenu()
	{
		MainMenuUI.SetActive(false);
		Time.timeScale = 1f;
		GameIsPaused = false;
	}
}
