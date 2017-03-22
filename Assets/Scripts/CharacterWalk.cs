using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterWalk : MonoBehaviour {

    private Animator anim;
    private Rigidbody rbody;
    private GameObject character;

    public Transform cam;

    //public Text debug;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        rbody = GetComponent < Rigidbody>();
        //debug.text = "Start!";
    }

    // Update is called once per frame
    void Update() {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        //debug.text = "Z key: " + move;
        anim.SetFloat("speed", 1.0f);
        
        bool move = Input.GetKey(KeyCode.Z);//Input.GetAxis("Vertical");
        if (move)
        {
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, cam.localEulerAngles.y, transform.localEulerAngles.z);
            transform.Translate(3 * Vector3.forward * Time.deltaTime);
        }
        else
        {
            anim.SetFloat("speed", 0.0f);
            //debug.text = "Z key(not): " + move;
        }
    }
}
