using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dondurme : MonoBehaviour
{

    public float hiz;
    float level2 = 1;
    void Update()
    {       
        transform.Rotate(0, 0, hiz * Time.deltaTime * level2);          
        if (int.Parse(SceneManager.GetActiveScene().name) == 2) 
        {
            if (Input.GetButtonDown("Fire1"))
            {
                level2 = Random.Range(0.5f,3f);
            }  
        }
        if (int.Parse(SceneManager.GetActiveScene().name) == 3)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                hiz *= -1;
            }
        }
    }
}
