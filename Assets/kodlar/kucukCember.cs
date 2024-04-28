using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kucukCember : MonoBehaviour
{
    Rigidbody2D fizik;
    GameObject oyunYoneticisi;
    public float hiz;
    bool hareketkontrol = true;
    

    void Start()
    {
        fizik = GetComponent<Rigidbody2D>();
        oyunYoneticisi = GameObject.FindGameObjectWithTag("oyunyoneticisi");
    }
    void FixedUpdate()
    {
        if (hareketkontrol) 
        {
            //if (int.Parse(SceneManager.GetActiveScene().name) == 2) 
            //{   
            //    fizik.MovePosition(fizik.position + Vector2.up * hiz * Time.deltaTime * Random.Range(1, 3));
            //}
            //else
            //{
                fizik.MovePosition(fizik.position + Vector2.up * hiz * Time.deltaTime);
            //}
        }  
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (!(int.Parse(SceneManager.GetActiveScene().name) == 5)) 
        {
            if (col.tag == "donenkuretag")
            {
                hareketkontrol = false;
                transform.SetParent(col.transform);
            }
        } 
        if (col.tag == "igne") 
        {
            oyunYoneticisi.GetComponent<oyunYoneticisi>().OyunBitti();
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (int.Parse(SceneManager.GetActiveScene().name) == 5) 
        {
            if (col.tag == "donenkuretag")
            {
                hareketkontrol = false;
                transform.SetParent(col.transform);
            }
        }
    }
}
