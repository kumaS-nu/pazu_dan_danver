using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisible_wall : MonoBehaviour {

    private MeshRenderer mesh;

	void Start () {
        mesh = GetComponent<MeshRenderer>();

        mesh.enabled = false;
	}
	
	
}
