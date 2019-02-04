using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CalculateGuess : MonoBehaviour {
	[SerializeField] int highLim = 1000;
	[SerializeField] int lowLim = 1;
	int currentGuess;
	[SerializeField] public TextMeshProUGUI guessText;
	[SerializeField] public Text moth;

	private void Start () {
		setText ();
	}
	public void onHighClicked () {
		lowLim = currentGuess + 1;
		setText ();
	}

	public void onLowClicked () {
		highLim = currentGuess;
		setText ();
	}

	private void setText () {
		int prvGuess = currentGuess;
		if (lowLim <= highLim) {
			currentGuess = Random.Range (lowLim, highLim);
		}

		if (currentGuess == prvGuess) {
			moth.text = "You dense, motherf***er. I already told it was ";
		}
		guessText.text = currentGuess.ToString ();
	}
}
