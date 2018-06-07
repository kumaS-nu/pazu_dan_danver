using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadScript : MonoBehaviour {

    public string str;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Scene1()
    {
        SceneManager.LoadScene(str);
#pragma warning restore CS0618 // Type or member is obsolete
    }

}

