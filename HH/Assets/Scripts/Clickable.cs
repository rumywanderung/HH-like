using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickable : MonoBehaviour
{
    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "tile")
        {
            collision.gameObject.tag = "clickable";
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "tile")
        {
            collision.gameObject.tag = "clickable";
        }
    }

    //private void OnTriggerExit(Collider collision)
    //{
    //    if (collision.gameObject.tag == "clickable")
    //    {
    //        collision.gameObject.tag = "tile";
    //    }
    //}
    
}
