using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadScript : MonoBehaviour {

    public string str;
    public bool is_Start;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxisRaw("Submit") != 1 && is_Start == true)
            Scene1();
        if (Input.GetAxisRaw("Vertical") != 1 || Input.GetAxisRaw("Horizontal") != 1 && is_Start == false)
            Scene1();
        if (Input.GetKey(KeyCode.Escape))
            Application.Quit();
	}

    public void Scene1()
    {
        SceneManager.LoadScene(str);
#pragma warning restore CS0618 // Type or member is obsolete
    }

}

