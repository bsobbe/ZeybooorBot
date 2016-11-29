using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	public int min;
	public int max;
	public int guess;
    public static int guessCount;

    public Text guessText;

	public NumberWizard()
	{
		this.SetDefaultValues();
	}

	void SetDefaultValues ()
	{
		min = 1;
		max = 1000;
        guessCount = 1;
	}

	void Start () 
	{
        this.NextGuess();
        this.max += 1;
    }

    public void GuessHigher()
    {
        this.min = this.guess;
        guessCount++;
        this.NextGuess();
    }

    public void GuessLower()
    {
        this.max = this.guess;
        guessCount++;
        this.NextGuess();
    }

    public static string GetGuessCount()
    {
        return guessCount.ToString();
    }

	public void NextGuess ()
	{
		this.guess = (max + min) / 2;
        this.guessText.text = this.guess.ToString();
	}
}
