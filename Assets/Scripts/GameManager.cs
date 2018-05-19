﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public CardView cardPrefab;

    List<Player> _players;
    private Player _currentPlayer;

    // GameManager singleton access
    public static GameManager instance { get; private set; }
    private void Awake() {
        if (instance == null) {
            instance = this;
        }
        else if (instance != this) {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

	private void Start() {
        // Init (players, scene, etc)
        // Populate local player's hand
        // Decide who goes first
        // Start game
	}

    public void EndTurn() {
        if (_players.Count != 2) {
            Debug.LogError("Unexpected number of players: " + _players.Count);
            return;
        }

        // End the current player's turn
        _currentPlayer.EndTurn();

        // Determine the next player and start their turn
        if (_currentPlayer == _players.First()) {
            _currentPlayer = _players.Last();
        } else {
            _currentPlayer = _players.First();
        }

        _currentPlayer.StartTurn();
    }

	private void Update() {
		// Tick current player's turn timer
            // If it expires, end their turn
	}
}