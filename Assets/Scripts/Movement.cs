using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public float angleSpeed;
    public Missle missle;
    private void Awake()
    {
        Debug.Log("On Awake >> " + speed);
    }

    private void OnEnable()
    {
        Debug.Log("On OnEnable");
    }
 
    void Start()
    {
        Missle tmp = Instantiate(missle, gameObject.transform.position, transform.rotation);
        //tmp.direction = gameObject.transform.forward;
        tmp.degAngle = gameObject.transform.eulerAngles.y;
        tmp.gameObject.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            gameObject.transform.position += speed * gameObject.transform.forward;
        if (Input.GetKey(KeyCode.DownArrow))
            gameObject.transform.position += -speed * gameObject.transform.forward;
        if (Input.GetKey(KeyCode.LeftArrow))
            gameObject.transform.position += -speed * gameObject.transform.right;
        if (Input.GetKey(KeyCode.RightArrow))
            gameObject.transform.position += speed * gameObject.transform.right;
        if (Input.GetKey(KeyCode.A))
            gameObject.transform.Rotate(Vector3.up, -angleSpeed);
        if (Input.GetKey(KeyCode.D))
            gameObject.transform.Rotate(Vector3.up, angleSpeed);
    }

    private void OnDisable()
    {
        Debug.Log("On OnDisable");

    }
}

