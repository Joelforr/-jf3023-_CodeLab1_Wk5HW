using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SavePlayerCharacter : MonoBehaviour {

	public string fileName = "temp.txt";
	private string filePath;

	const char DELIMITER = '|';

	private CharacterSetup _charSetup;

	// Use this for initialization
	void Start () {
		_charSetup = FindObjectOfType<CharacterSetup> ();
		filePath = Application.dataPath + "/" + fileName;

		if(File.Exists(filePath)){
			
		}	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.S)){
			StreamWriter sw = new StreamWriter (filePath, false);

			sw.WriteLine ("" +
			_charSetup.charName + DELIMITER +
			_charSetup.charRace.ToString () + DELIMITER +
			_charSetup.charClass.ToString ());

			sw.Close ();
		}
	}
}
