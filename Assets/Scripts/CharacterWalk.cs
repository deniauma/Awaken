using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterWalk : MonoBehaviour {

    private Animator anim;
    private Rigidbody rbody;
    private GameObject character;
    private Vector3 lastCharacterLocalEulerAngles;

    public Transform cam;

    //public Text debug;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        rbody = GetComponent < Rigidbody>();
        lastCharacterLocalEulerAngles = transform.localEulerAngles;
        //debug.text = "Start!";
    }

    // Update is called once per frame
    void Update() {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        bool moveForward = Input.GetKey(KeyCode.Z);
        bool moveBackward = Input.GetKey(KeyCode.S);
        bool moveLeft = Input.GetKey(KeyCode.Q);
        bool moveRight = Input.GetKey(KeyCode.D);
        //debug.text = "Z key: " + move;
        anim.SetFloat("speed", 1.0f);
        
        bool move = moveForward || moveBackward || moveLeft || moveRight;

        if (move)
        {

            if (moveBackward)
            {
                transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, cam.localEulerAngles.y + 180, transform.localEulerAngles.z);
                //transform.Translate(-3 * Vector3.forward * Time.deltaTime);
            }
            else if (moveLeft)
            {
                transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, cam.localEulerAngles.y - 90, transform.localEulerAngles.z);
                //transform.Translate(3 * Vector3.left * Time.deltaTime);
            }
            else if (moveRight)
            {
                transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, cam.localEulerAngles.y + 90, transform.localEulerAngles.z);
                //transform.Translate(3 * Vector3.left * Time.deltaTime);
            }
            else if(moveForward)
            {
                transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, cam.localEulerAngles.y, transform.localEulerAngles.z);
                //transform.Translate(3 * Vector3.forward * Time.deltaTime);
            }
            transform.Translate(3 * Vector3.forward * Time.deltaTime);
        }
        else
        {
            anim.SetFloat("speed", 0.0f);
            //debug.text = "Z key(not): " + move;
        }
    }
}
