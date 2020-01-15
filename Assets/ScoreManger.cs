using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManger : MonoBehaviour {

	
	public GameObject score_object = null;
	public int score_num;

	void Start () {
		Initialize ();
	}

	void Update () {
		
		Text score_text = score_object.GetComponent<Text> ();

		score_text.text = "SCORE:" + score_num;
	}
    public void AddPoint (int point)
    {
        score_num =  score_num + point;
    }

    private void Initialize ()
    {
    	score_num = 0;
    }
}
