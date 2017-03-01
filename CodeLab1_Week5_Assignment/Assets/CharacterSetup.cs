using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSetup : MonoBehaviour {


	public Globals.CharRace charRace;
	public Globals.CharClass charClass;
	public string charName;

	private Renderer rend;
	private Color skinColor;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		rend.material.color = skinColor;	

		if (charRace == Globals.CharRace.Elf){
			skinColor = Color.green;
		}else if(charRace == Globals.CharRace.Orc){
			skinColor = Color.red;
		}else if(charRace == Globals.CharRace.Human){
			skinColor = Color.yellow;
		}else if(charRace == Globals.CharRace.Demon){
			skinColor = Color.magenta;
		}else{
			skinColor = Color.white;
		}
	}
}
