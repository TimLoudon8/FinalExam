using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xPos = Input.GetAxis("Horizontal");
        float yPos = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(xPos * speed, yPos * speed, 0);
        move *= Time.deltaTime;
        transform.Translate(move);
    }
}
