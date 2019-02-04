using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CalculateGuess : MonoBehaviour {
	[SerializeField] int highLim = 1000;
	[SerializeField] int lowLim = 1;
	int currentGuess;
	[SerializeField] public TextMeshProUGUI guessText;

	private void Start () {
		setText ();
	}
	public void onHighClicked () {
		lowLim = currentGuess;
		setText ();
	}

	public void onLowClicked () {
		highLim = currentGuess;
		setText ();
	}

	private void setText () {
		currentGuess = (highLim + lowLim) / 2;
		guessText.text = currentGuess.ToString ();
	}
}
