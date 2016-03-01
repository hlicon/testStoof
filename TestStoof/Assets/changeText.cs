using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class changeText : MonoBehaviour {

	public Text targetText;

	public void ChangeText(string newText){
		targetText.text = newText;
	}
}
