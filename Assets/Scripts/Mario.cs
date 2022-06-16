
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario : MonoBehaviour
{
    
private Rigidbody2D BodyMario;
public float speed = 1;
public float jumpHeight = 1;

void Start()
{
BodyMario = GetComponent<Rigidbody2D>();
}

void Update()
{
float a = Input.GetAxisRaw("Horizontal");
BodyMario.velocity = new Vector2(a*speed,BodyMario.velocity.y);

if(Input.GetKeyDown(KeyCode.UpArrow))
  BodyMario.velocity += Vector2.up*jumpHeight;
    }

}