using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class sepet : MonoBehaviour
{
    public float hiz;
    int skor = 0;
    public TextMeshProUGUI skor_txt;


    // using TMPro;   kütüphanesini eklemeden de yapabiliriz.

    //private void Start()
    //{
    //   skor_txt = GameObject.Find("Canvas/skor_txt").GetComponent<TextMeshProUGUI>();
    // }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="elma")
        {
            skor += 10;
            //Debug.Log(skor.ToString());
            skor_txt.text = skor.ToString();

            // float rast = Random.Range(-9.5f, 8);

            // collision.gameObject.transform.position = new Vector3(rast, 10f, 27.58f);

            Destroy(collision.gameObject);
            Time.timeScale = 0;
        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(hiz * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-hiz * Time.deltaTime, 0, 0);
        }
    }
}
