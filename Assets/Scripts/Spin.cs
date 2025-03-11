using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public Vector3 direction = new Vector3(0,1,0);

    void Update()
    {
        this.transform.Rotate(direction);
    }
}
