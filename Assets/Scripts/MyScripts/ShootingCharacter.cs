using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingCharacter : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _spawnPointBullet;
    
    
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Shoot();            
        }        
    }
       

    private void Shoot()
    {
        Instantiate(_bullet, _spawnPointBullet.position, _spawnPointBullet.rotation);

    }
}
