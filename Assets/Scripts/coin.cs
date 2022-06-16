using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public int score;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

  void OnCollisionEnter2D(Collision2D mehman)
    {
        Destroy(gameObject);
         score ++;
         Debug.Log(score);
    }

  
}
