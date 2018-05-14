using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Spell Card", menuName = "Spell Card")]
public class SpellCard:Card {

  private override bool targetable = false;
	private override bool canTarget = true;

  /**
   *  @function UseSpell
   *  @description Use this spell card and carry out any event scripts.
   */
  public void UseSpell(){
      // this.whenPlayed;

      // once used:
      // this.DestroyCard();
  }
}
