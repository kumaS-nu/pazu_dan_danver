using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow1 : MonoBehaviour {
    public Transform target;
    public float x;
    public float y;
    public float z;
    private Vector3 offset;
    // Use this for initialization
    void Start () {
         offset = new Vector3(x, y, z);   
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Transform>().position = target.position + offset;
        GetComponent<Transform>().LookAt(target);
    }
}
