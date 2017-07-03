using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueBox : MonoBehaviour {

	public void ToggleAlertScreen () {

		gameObject.SetActive (!gameObject.activeSelf);

	}

	public void BuyFullApp () {
		Application.OpenURL ("itms-apps://itunes.apple.com/app/id1212142417"); 
	}

}
