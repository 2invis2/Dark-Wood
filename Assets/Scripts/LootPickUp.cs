﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootPickUp : MonoBehaviour
{
    public AudioClip pickUp;
    private AudioSource audio;
    public string itemName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnEnable()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log(itemName + " collected");
            audio.PlayOneShot(pickUp);
            GameLogic.CollectItem(itemName);
            Destroy(this.gameObject);
			if (itemName == "Compass")
				GameObject.FindGameObjectWithTag("Compass").GetComponent<Transform>().position = new Vector3(100, 100, 0);
        }
			
	}
}
