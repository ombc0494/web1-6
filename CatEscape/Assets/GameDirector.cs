using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour {
    GameObject hpGauge;

	// Use this for initialization
	void Start () {
        this.hpGauge = GameObject.Find("hpGauge");

    }
	
	// Update is called once per frame
	void Update () {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
		
	}
}
