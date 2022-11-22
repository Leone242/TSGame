using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    private Rigidbody2D rBody;
    private Transform collisionCheck;
    [SerializeField]
    private Manager manager;
    private bool isSelected = true;
    [SerializeField]
    private float speed;



    void Awake()
    {
        this.rBody = this.GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        Vector3 direction = new Vector3();
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
        if(isSelected)
        {
            transform.position += direction * speed;
        }
        
    }
}
