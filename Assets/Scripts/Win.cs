using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Win : MonoBehaviour {

    public Text guessCount;

	void Start () {
        guessCount.text = NumberWizard.GetGuessCount();
	}
	
}
