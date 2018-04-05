using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillYourself : MonoBehaviour {

    private float DeadTimer = 0;
	
	// Update is called once per frame
	void Update () {
        DeadTimer += 1 * Time.deltaTime;
        if (DeadTimer >= 1)
            Destroy(gameObject);
	}
}
