using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy2 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject); 
    }
}
