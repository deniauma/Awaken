using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterWalk : MonoBehaviour {

    private Animator anim;
    private GameObject character;
    //public Text debug;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        //debug.text = "Start!";
    }
	
	// Update is called once per frame
	void Update () {
        bool move = Input.GetKey(KeyCode.Z);//Input.GetAxis("Vertical");
        if (move)
        {
            //debug.text = "Z key: " + move;
            anim.SetFloat("speed", 1.0f);
            Vector3 newPos = anim.transform.position;
            newPos.z += 2.0f * Time.deltaTime;
            anim.transform.position = newPos;
        }
        else
        {
            anim.SetFloat("speed", 0.0f);
            //debug.text = "Z key(not): " + move;
        }
    }
}
