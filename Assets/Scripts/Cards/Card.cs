﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class Card : ScriptableObject {

	public Sprite cardArt;

	public string cardName;
	public string cardType;
	public string abilities;

	public int manaCost;
	public int attackPower;
	public int health;

	private bool targetable; // Other cards can target this card
	private bool canTarget;  // This card can target other cards

	// Event triggers
	// @TODO: Implement these under the GameAction class (currently these are placeholder objects)
	public object whenAttacking;
	public object whenPlayed;
	public object whenDestroyed;
	public object whenTargeted;
	public object whenDrawn;

	/**
	 *  @function PlayCard
	 *  @description Play this card from the player's hand and onto the field.
	 */
	public void PlayCard(){
		// this.whenPlayed
	}

	/**
	 *  @function DestroyCard
	 *  @description Remove this card from the battlefield.
	 */
	public void DestroyCard(){
		// this.whenDestroyed
	}

}
