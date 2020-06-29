using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public static float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        // Horizontal
        Vector3 movmentX = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
        transform.position += movmentX * Time.deltaTime * speed;

        // Vertical
        Vector3 movmentY = new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
        transform.position += movmentY * Time.deltaTime * speed;
    }
}
