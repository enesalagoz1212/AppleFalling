using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zemin : MonoBehaviour
{
	float can = 100;
	float su_anki_can = 100;
	Image can_bari;
	public GameObject panel;

	private void Start()
	{
		can_bari = GameObject.Find("Canvas/Image/can_bari").GetComponent<Image>();
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "elma")
		{

			// float rast = Random.Range(-9.5f, 8);

			// collision.gameObject.transform.position = new Vector3(rast, 10f, 27.58f);
			// Destroy(collision.gameObject);

			Destroy(collision.gameObject);
			su_anki_can -= 10;

			can_bari.fillAmount = su_anki_can / can;

			if (su_anki_can <= 0)
			{
				panel.SetActive(true);
				Time.timeScale = 0.0f;
			}

		}

	}



	void Update()
	{

	}
}
