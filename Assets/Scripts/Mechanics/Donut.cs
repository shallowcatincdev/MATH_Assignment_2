using Platformer.Mechanics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donut : MonoBehaviour
{
    [SerializeField] PlayerController controller;


    private void OnTriggerEnter2D(Collider2D other)
    {

        var player = other.gameObject.GetComponent<PlayerController>();
        if (player != null)
        {

           
            controller.GetPowerUp();
            Destroy(this.gameObject);
            
        }
    }

}
