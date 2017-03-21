using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPSmouseLook : MonoBehaviour {

    private Vector2 mouseLook;
    private Vector2 smoothV;
    private GameObject character;

    public Transform targetLock;
    public float sensivity = 5.0f;
    public float smoothing = 2.0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Quaternion rotation = Quaternion.LookRotation(targetLock.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * sensivity);
    }
}
