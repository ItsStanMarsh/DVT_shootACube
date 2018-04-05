using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lifecounter : MonoBehaviour {

    public int lives = 3;
    public Text uiText;

     void Start()
    {
        UpdateUI();
    }
    void OnTriggerEnter(Collider other)
    {
      

        if (other.CompareTag("cube")){

            Destroy(other.gameObject);

            lives--;

            UpdateUI();

            if (lives == 0)
            {
                print("Game Over");
            }
        }
        
    }
    public void UpdateUI()
    {
        uiText.text = "lives: " + lives.ToString();
    }
}

