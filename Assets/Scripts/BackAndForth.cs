using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackAndForth : MonoBehaviour
{
    public float speed = 3.0f;
    public float maxX = 20.0f; 
    public float minX = -2f;
    private int _direction = 1; 
    void Update()
    {
        transform.Translate(_direction * speed * Time.deltaTime, 0, 0);

        bool bounced = false;
        if (transform.position.x > maxX || transform.position.x < minX)
        {
            _direction = -_direction; 
            bounced = true;
        }
        if (bounced)
        {
            transform.Translate(_direction * speed * Time.deltaTime, 0, 0);
        }
    }

}
