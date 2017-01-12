using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireballController : MonoBehaviour {

    private Text debugText;

	// Use this for initialization
	void Start () {
        debugText = GameObject.FindGameObjectWithTag("Debug").GetComponent<Text>();
        debugText.text = "Fireball";
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionExit()
    {
        debugText.text = "Collision fireball";
        Destroy(gameObject, 0.0f);
    }
}
