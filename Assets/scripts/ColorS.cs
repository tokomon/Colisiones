using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorS : MonoBehaviour
{

    void OnCollisionEnter(Collider other)
    {
        this.GetComponent<Renderer>().material.color = Color.blue;
        /*  if (other.name == "Detection Zone")
          {
              inSight = true;
          }
  */
    }

    void OnCollisionExit(Collider other)
    {/*
        if (other.name == "Detection Zone")
        {
            Debug.Log("leavingtrigger");
            inSight = false;
            Debug.Log("not in sight");
        }*/
    }
}
