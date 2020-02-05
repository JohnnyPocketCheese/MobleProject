using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed = 2;
    public bool movingRight = true;
    public Transform groundDetection;
    public float raycastLength = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, raycastLength);
        if (groundInfo.collider == false)
        {
            //Debug.Log("Edge hit" + transform.name);
            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
            
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, raycastLength);
        if (collision.contacts[0].normal == new Vector2(1, 0) || collision.contacts[0].normal == new Vector2(-1, 0))
        {
            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
            //Debug.Log("Wall hit " + transform.name);
        }
    }

}
