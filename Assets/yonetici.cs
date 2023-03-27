using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yonetici : MonoBehaviour
{
    int saniye = 10;
    public GameObject elma;

    bool oyun_durduruldu = false;

    public void tekar_oyna_btn()
    {
        SceneManager.LoadScene("Scene/SampleScene");
    }




    public void durdur_btn()
    {

        oyun_durduruldu = !oyun_durduruldu;

        if (oyun_durduruldu==true)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }










  
    void Start()
    {
        //Invoke("saniye_azalt", 1.0f);
        // InvokeRepeating("saniye_azalt", 0.0f, 1.0f);

        InvokeRepeating("elma_ekle", 0.0f, 1f);

    }
    // void saniye_azalt()
    // {
    //  saniye--;
    //  Debug.Log(saniye.ToString());
    //  if (saniye==5)
    //  {
    // CancelInvoke("saniye_azalt");
    // CancelInvoke();bütün ýnvoke larý durduran komut
    // }

    //}

    void elma_ekle()
    {
        float rast = Random.Range(-9.5f, 8);
        GameObject yeni_elma=Instantiate(elma,new Vector3(rast,10f,27.58f),Quaternion.identity);

        
    }

    

    void Update()
    {
        Debug.Log(Time.time.ToString());
        Time.timeScale = 0.5f;
        
    }
}
