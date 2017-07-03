using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainSettings : MonoBehaviour {

	public GameObject[] panels;
	public GameObject starsContainer;

	public void RestoreDefault () {

		foreach (Transform child in transform) {

			child.gameObject.SetActive (false);

		}
		panels [0].SetActive (true);

	}

	public void DeleteRecords () {
		
		File.Delete (Application.persistentDataPath + "/noteMasterSettings.dat");
		File.Delete (Application.persistentDataPath + "/noteMasterRecords.dat");
		File.Delete (Application.persistentDataPath + "/iGotRhythmSettings.dat");
		File.Delete (Application.persistentDataPath + "/iGotRhythmRecords.dat");
		File.Delete (Application.persistentDataPath + "/musiclyLanguage.dat");
		File.Delete (Application.persistentDataPath + "/tutorialStatus.dat");
		File.Delete (Application.persistentDataPath + "/feedbackRecord.dat");
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);

	}

	public void Return () {
	
		foreach (Transform child in transform) {
			child.gameObject.SetActive (true);
		}

		for (int i=0; i<panels.Length; i++) {
			panels [i].SetActive (false);
		}

	}		
}
