using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    private Rigidbody2D rBody;
    private Transform collisionCheck;
    [SerializeField]
    private Manager manager;


    void Awake()
    {
        this.rBody = this.GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        
    }
}
