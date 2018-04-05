using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletscript : MonoBehaviour {

    public float speed = 20;
    public GameObject addCounter;
    

	void Update () {
        transform.Translate(Vector3.up * Time.deltaTime * speed, Space.Self);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("cube"))
        {
            Destroy(other.gameObject);
            Instantiate(addCounter);

        }
     
    }
}
