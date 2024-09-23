using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public PlayerController player;
    public Vector3 offset; 
    public float smoothSpeed = 0.125f;

    void Start()
    {
        player = FindObjectOfType<PlayerController>(); 
        offset = transform.position - player.transform.position; 
    }

    void LateUpdate()
    {
        Vector3 desiredPosition = player.transform.position + offset; 
        transform.position = desiredPosition; 
    }
}
