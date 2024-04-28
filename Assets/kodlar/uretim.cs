using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uretim : MonoBehaviour
{
    public GameObject igne;
    GameObject oyunyoneticisi;
    void Start()
    {
        oyunyoneticisi = GameObject.FindGameObjectWithTag("oyunyoneticisi");
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) 
        {
            Instantiate(igne, transform.position, transform.rotation);
            oyunyoneticisi.GetComponent<oyunYoneticisi>().Igne();
        }    
    }
}
