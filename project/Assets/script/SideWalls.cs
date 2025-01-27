﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWalls : MonoBehaviour
{
    // Pemain yang akan bertambah skornya jika bola menyentuh dinding ini.
    public PlayerControl player;
    // public BallControl ball;
    // Skrip GameManager untuk mengakses skor maksimal
    [SerializeField]
    private GameManager gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Akan dipanggil ketika objek lain ber-collider (bola) bersentuhan dengan dinding. ==> event triger
    void OnTriggerEnter2D(Collider2D anotherCollider)
    {
        // Jika objek tersebut bernama "Ball" 
        if (anotherCollider.name == "Ball")
        {
            player.IncrementScore(); //GOll+
            // Jika skor pemain belum mencapai skor maksimal...
            if (player.Score < gameManager.maxScore)
            {
                // ...restart game setelah bola mengenai dinding.
                anotherCollider.gameObject.SendMessage("RestartGame", 2.0f, SendMessageOptions.RequireReceiver);
            }
        }
    }
}
