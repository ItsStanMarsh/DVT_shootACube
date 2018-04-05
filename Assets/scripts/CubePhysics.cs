using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePhysics : MonoBehaviour {

    public float timer;

	void Update () {

        timer += 4 * Time.deltaTime;

        if(timer <= 2)
        {
            transform.position += new Vector3(-0.05f, -0.05f, 0);
        }
        if(timer >= 2)
        {
            transform.position += new Vector3(0.05f, -0.05f, 0);
            
        }
        if (timer >= 4)
        {
            timer = 0;
        }
    }
}
