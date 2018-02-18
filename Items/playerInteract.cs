using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script is to be attached to the entity

public class playerInteract : MonoBehaviour {

	public GameObject currentInterObj = null;
	//Public so we can watch what's happening in the inspector during debugging, though we may want to change this later

	void Update() //Gets called every frame
	{
		if (Input.GetButtonDown ("Interact") && currentInterObj) //We will need to set the Interact button up manually in Unity
		{
			//If the player is pushing the designated interact button, and the current interactable object is set to an item:
			//Do something with item

			currentInterObj.SendMessage("DoInteraction");
			//Tells the interactItem script to perform DoInteraction function
		}
	}

	void OnTriggerEnter2D(Collider2D other) //We need to set the trigger in Unity to go off when a character enters the range of an item
	{
		if (other.CompareTag ("interItem")) //This tag will be attached to all interactive items
		{
			Debug.Log (other.name); //This just gives us the name of the object when we walk into range
			currentInterObj = other.gameObject; //Sets the current interactable object to this item
		}
	}

	void OnTriggerExit2d (Collider2D other) //When we walk out of range
	{
		if (other.CompareTag ("interItem")) 
		{
			if (other.gameObject == currentInterObj) 
			{
				currentInterObj = null;
				//Once we exit range, the current interactive object goes back to null
				//May have to update this if there will ever be more than one item in range too close together
				//But then again I'm not sure how Unity would react to that
			}
		}
	}
}
