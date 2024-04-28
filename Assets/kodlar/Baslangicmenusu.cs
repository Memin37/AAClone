using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Baslangicmenusu : MonoBehaviour
{
    int kayitlilevel;
    void Start()
    {
        kayitlilevel = PlayerPrefs.GetInt("kayit");
    }   
    public void OyunuBaslat() 
    {
        if (kayitlilevel == 0) 
        {
            EditorSceneManager.LoadScene(kayitlilevel + 1);     
        }
        else 
        {
            EditorSceneManager.LoadScene(kayitlilevel);
        }
    }
    public void YenidenBasla()
    {
        PlayerPrefs.DeleteKey("kayit");
        kayitlilevel = 0;
    }
    public void OyunuBitir() 
    {
        Application.Quit();   
    }
}
