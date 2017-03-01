using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class LoadPlayerCharacter : MonoBehaviour {

	const char DELIMITER = '|';

	public string[] fileNames;
	string fileName;
	string filePath; 

	// Use this for initialization
	void Start () {
		fileName = "temp.txt";
		filePath = Application.dataPath + "/" + fileName;

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.L)){
			StreamReader sr = new StreamReader(filePath);

			GameObject player = Instantiate (Resources.Load ("prefabs/Player") as GameObject);
			CharacterSetup _charSetup = player.GetComponent<CharacterSetup> ();

				string line = sr.ReadLine ();
				sr.Close ();

				string[] splitLine = line.Split (DELIMITER);

				_charSetup.charName = splitLine [0];
			if(System.Enum.IsDefined(typeof(Globals.CharRace), splitLine[1])){
				_charSetup.charRace = (Globals.CharRace)System.Enum.Parse (typeof(Globals.CharRace), splitLine [1]);
			}

			_charSetup.charClass = (Globals.CharClass)System.Enum.Parse (typeof(Globals.CharClass),splitLine [2]);


		}
	}
}
