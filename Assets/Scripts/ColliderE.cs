using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColliderE : MonoBehaviour
{

    public GameObject player;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Lava")
        {
            player.SetActive(false);

        }
        else if (other.gameObject.tag == "Meteor")
        {

            player.SetActive(false);

        }

    }


}
