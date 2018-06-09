using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_SceneLoad : MonoBehaviour {
    private bool pushed;
    public InputManager pname;
	// Use this for initialization
	void Start () {
        pushed = false;
	}
	
	public void Push()
    {
        if (pname.inputValue != "")
        {
            pushed = true;
        }
        else
        {
            SceneManager.LoadScene("Result");
        }
    }

    public bool Get_pushed()
    {
        return pushed;
    }
}
