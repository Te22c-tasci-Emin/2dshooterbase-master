using System;
using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class shipController : MonoBehaviour
{
    [SerializeField]

    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float speed = 5.5f;

        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");


        Vector2 movementx = new Vector2(moveX, 0);
        Vector2 movementy = new Vector2(0, moveY);

        Vector2 movement = movementx + movementy;


        transform.Translate(movement * speed * Time.deltaTime);

        if (Mathf.Abs(transform.position.x) > 10)
        {

            transform.Translate(-movementx * speed * Time.deltaTime);
        }

        if (MathF.Abs (transform.position.y) > 4 )
        {
            transform.Translate(-movementy * speed * Time.deltaTime);
        }


    }
}
