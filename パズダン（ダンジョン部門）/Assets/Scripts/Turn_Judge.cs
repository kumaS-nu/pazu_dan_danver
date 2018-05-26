using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn_Judge : MonoBehaviour {

    public Swith s1;
    public bool s_1;
    public Swith s2;
    public bool s_2;
    public Swith s3;
    public bool s_3;
    public Swith s4;
    public bool s_4;
    public bool son;




    // Update is called once per frame
    void Update () {
        if (son == true)
            son = false;

        if (s_1 == true && s1.swi == true){
            son = true; Debug.Log("go1");
        }

        if (s_2 == true && s2.swi == true){
            son = true; Debug.Log("go2");
        }

        if (s_3 == true && s3.swi == true){
            son = true; Debug.Log("go3");
        }

        if (s_4 == true && s4.swi == true){
            son = true; Debug.Log("go4");
        }
        

    }
}
