using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public int hits = 1;
    public int points = 10;
    void Start()
    {
      

    }

   
    void Update()
    {
        
    }
   private void OnCollisionEnter(Collision collision)
    {
        hits--;
        //score points
        if  (hits <- 0)
        {
            Destroy(gameObject);

        }
    }
}
