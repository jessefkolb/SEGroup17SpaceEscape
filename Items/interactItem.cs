using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script is paired with the playerInteract script
//When the player is in range of an item, and requests to pick up the item, the "DoInteraction" function is called

public class interactItem : MonoBehaviour {

	void DoInteraction() //Picked up, later put in inventory too IF not full
	{
		
    gameObject.SetActive (false); //Item disappears from map

		//Obviously we need to set up an inventory to store the item
		//I think this should be done BEFORE we start using the items
		//Otherwise we have to implement a system to have the player carry one item at a time, only to discard it later
		//It's better to just get the inventory implemented first, once that's done, using the item should be simple
	
  }

}
