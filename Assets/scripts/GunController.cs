using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {

    public float rotationSpeed = 100;
    public GameObject prefab;
    public GameObject bulletprefab;


	void Update ()
    {

        float xInput = Input.GetAxisRaw("Horizontal");
        print(xInput);

        transform.Rotate(new Vector3(0, 0, xInput * rotationSpeed * -1) * Time.deltaTime);


        if (Input.GetButtonDown("Fire1"))
        {
            Shot();
        }

    }

    void Shot()
    {
        Instantiate(bulletprefab, prefab.transform.position, prefab.transform.rotation);
    }
}
