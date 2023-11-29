using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listener : MonoBehaviour
{
    [SerializeField] Transform player;
    void Update()
    {
        if(player)
        {
            transform.position = player.position;   
        }
    }
}
