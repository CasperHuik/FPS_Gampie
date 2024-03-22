using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 0f;
    public Transform player;
    public Transform spawnPoint;
    public GameObject bullet;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Fire();
        }
    }

    void Fire(){
        
        Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
        
    }
}
