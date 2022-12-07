using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Command : MonoBehaviour
{
    public GameObject pellet;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            int xPos = Random.Range(-9, 9);
            int yPos = Random.Range(-3, 3);
            Instantiate(pellet, new Vector2(xPos, yPos), transform.rotation);
        }
    }
}
