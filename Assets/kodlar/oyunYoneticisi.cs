using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class oyunYoneticisi : MonoBehaviour
{
    GameObject dondurme;
    GameObject uretici;
    public Animator animator;
    public Text levelismi;
    public Text ignesayisitext;
    int ignesayisi = 9;
    bool kontrol = true;
    bool kontrol2 = true;

    void Start()
    {
        PlayerPrefs.SetInt("kayit", int.Parse(SceneManager.GetActiveScene().name));
        dondurme = GameObject.FindGameObjectWithTag("donenkuretag");
        uretici = GameObject.FindGameObjectWithTag("uretici");      
        levelismi.text = "Level "+SceneManager.GetActiveScene().name;    
    }
    void Update()
    {
        if (kontrol2) 
        {
            ignesayisitext.text = ignesayisi + ""; 
        } 
    }
    public void YeniLevel() 
    {
        StartCoroutine(YeniLevelMi());  
    }
    IEnumerator YeniLevelMi() 
    {
        yield return new WaitForSeconds(0.5f);
        uretici.GetComponent<uretim>().enabled = false;
        dondurme.GetComponent<dondurme>().enabled = false;
        kontrol2 = false;
        yield return new WaitForSeconds(1f);
        if (kontrol) 
        {
            animator.SetTrigger("yeniLevel");
            yield return new WaitForSeconds(0.6f);
            SceneManager.LoadScene(int.Parse(SceneManager.GetActiveScene().name) + 1);           
        }
    }
    public void OyunBitti()
    {
        StartCoroutine(OyunBittiMi());
    }
    IEnumerator OyunBittiMi() 
    {
        kontrol = false;
        kontrol2 = false;
        ignesayisitext.text = "";
        dondurme.GetComponent<dondurme>().enabled = false;
        uretici.GetComponent<uretim>().enabled = false;
        animator.SetTrigger("oyunBitti");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Anamenu");
    }
    public void Igne() 
    {
        ignesayisi--;
        if (ignesayisi == 0)
        {
            YeniLevel();
            ignesayisitext.text = "";
        }   
    }
}
