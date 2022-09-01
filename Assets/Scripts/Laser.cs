using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField]
    private float _speed = 8.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 1, 0) * _speed * Time.deltaTime);

       if(transform.position.y > 6f)
        {
            //check if this object has a parent.
            //destroy the parent too!
            if(transform.parent != null)
            {
                Destroy(transform.parent.gameObject);
            }
            
            Destroy(this.gameObject);
        }
    }
}