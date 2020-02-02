using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private AudioSource aS;

    public bool soundActive;
    void OnTriggerEnter(Collider other)
    {
        player.transform.position = respawnPoint.transform.position;
        if (soundActive)
            aS.Play();
    }

}