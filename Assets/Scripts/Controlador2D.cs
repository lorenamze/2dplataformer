using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador2D : MonoBehaviour
{
    Rigidbody2D rgbody;
    public float vel;
    public float jumpHeight;
    private float moveVel;

    // Start is called before the first frame update
    void Start()
    {
        rgbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       Vector2 direction = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
       rgbody.velocity = new Vector2(vel*direction.x,rgbody.velocity.y);

       if (direction.x > 0) {
            moveVel = vel;
            rgbody.velocity = new Vector2(moveVel, 0);
        }

        if (direction.x < 0) {
            moveVel = -vel;
            rgbody.velocity = new Vector2(moveVel, 0);
        }

       if (direction.y > 0)
        {
            rgbody.velocity = new Vector2(moveVel, jumpHeight);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "rosa")
        {
            Puntos.numPoints++;
            Destroy(col.gameObject);
        }

        if (col.gameObject.tag == "roja")
        {
            Puntos.numPoints=Puntos.numPoints+2;
            Destroy(col.gameObject);
        }

        if (col.gameObject.tag == "portal")
        {
            ManejaEscenas.ChangeScene("win");
        }
    }
}
