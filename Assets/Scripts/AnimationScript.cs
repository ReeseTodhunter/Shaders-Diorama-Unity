using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    public Material Walls, Floor;
    public Material Keyboard;
    public Material Matrix;

    public bool Coloured = false;
    public bool Rainbow = false;
    public bool Transparent = false;
    public bool GridOn = false;

    // Update is called once per frame
    private void Update()
    {
        //Test

        //if(Input.GetKey(KeyCode.Space))
        //{
        //    GridOn = true;
        //}
        //else
        //{
        //    GridOn = false;
        //}

        if (Coloured)
        {
            Keyboard.SetInt("_Coloured", 1);
        }
        else
        {
            Keyboard.SetInt("_Coloured", 0);
        }

        if (Rainbow)
        {
            Keyboard.SetInt("_Rainbow", 1);
        }
        else
        {
            Keyboard.SetInt("_Rainbow", 0);
        }

        if (Transparent)
        {
            Matrix.SetInt("_SeeThrough", 1);
        }
        else
        {
            Matrix.SetInt("_SeeThrough", 0);
        }

        if (GridOn)
        {
            Walls.SetInt("_GridOn", 1);
            Floor.SetInt("_GridOn", 1);
        }
        else
        {
            Walls.SetInt("_GridOn", 0);
            Floor.SetInt("_GridOn", 0);
        }
    }
}
