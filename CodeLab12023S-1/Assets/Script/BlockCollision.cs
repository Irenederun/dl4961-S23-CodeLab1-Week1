using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BlockCollision : MonoBehaviour
{
    public static int force = 6;//can be accessed from another script
    public TextMeshProUGUI controls;
    public string reverseControls;
    public string normalControls;

    private void Start()
    {
        var reverseBlock = this.gameObject.GetComponent<Renderer>();
        reverseBlock.material.SetColor("_Color", Color.black);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("collided");
        //force = WASDController.forceAmount;
        force = force * -1;
        //everytime player collides with it, it reverses force, hence reverses the forceAmount in WASDController script

        var renderer = collision.gameObject.GetComponent<Renderer>();
        //get the renderer of the player object 
        
        if (force == -6) //if force has been reverses -> reversed state
        {
            renderer.material.SetColor("_Color", Color.black);
            //mark the player object as black
            controls.text = reverseControls;
            //and change guidance text
            controls.color = Color.black;
            //also the color of the text
        }

        if (force == 6) //if in normal state
        {
            renderer.material.SetColor("_Color", Color.white);
            //return obj to white
            controls.text = normalControls;
            //return text
            controls.color = Color.white;
            //return text color
        }
    }
    //on collision only works when both have rb. one needs to be non-kinematic, though.
}
