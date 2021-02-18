using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missle : MonoBehaviour
{
    //public float deadTime;
   // private float lifeTime;
    public float speed;
    public float degAngle;
    private Vector3 direction;
    private void Start()
    {
        float radAngle = degAngle * Mathf.Deg2Rad;
        direction = new Vector3(Mathf.Sin(radAngle), 0, Mathf.Cos(radAngle));
    }
    // Update is called once per frame
    void Update()
    {
        //lifeTime += Time.deltaTime;
        //if (lifeTime > deadTime)
        //    Destroy(gameObject);
        gameObject.transform.position += direction * speed;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wall" || other.tag == "brick" || other.tag == "Player")
        {
            RaycastHit hit;
            Ray ray = new Ray(transform.position, direction);

            if (Physics.Raycast(ray, out hit))
            {
                direction = Vector3.Reflect(direction, hit.normal);
            }
        }

    }
}