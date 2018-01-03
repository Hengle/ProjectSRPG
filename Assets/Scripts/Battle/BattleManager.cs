using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour {

	private enum BattleState{
		START,
		PLAYERTURN,
		ENEMYTURN,
		WIN,
		LOSE
	}

	// Place holder for turn order 
	private SortedDictionary<int, int> turnOrder;

	private BattleState currentBattleState;


	// Use this for initialization
	void Start() {
		currentBattleState = BattleState.START;
		GenerateTurnOrder();
	}
	
	// Update is called once per frame
	void Update() {
		// Based on state we do something
		switch (currentBattleState) {
			case BattleState.START :
				break;
			default :
				break;
		}
	}

	private void GenerateTurnOrder() {
		// Obtain lists of PCs and Enemies
		// Randomly assign a turn order
	}

	private void OnTurnEnd() {
		// Check for win or lose condition
	}
}
