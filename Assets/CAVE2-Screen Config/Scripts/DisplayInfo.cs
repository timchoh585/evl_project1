﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class DisplayInfo : MonoBehaviour {

    // getReal3D screen parameters
    public Vector3 Px_UpperLeft;
    public Vector3 Px_LowerLeft;
    public Vector3 Px_LowerRight;

    // CalVR screen parameters
    public Vector3 origin; // pixel origin
    public float h; // Screen rotation

    public float unitMultiplier = 1; // meters by default

    // Use this for initialization
    void Start () {
        Px_UpperLeft = gameObject.transform.Find("Borders/PixelSpace/Px-UpperLeft").position;
        Px_LowerLeft = gameObject.transform.Find("Borders/PixelSpace/Px-LowerLeft").position;
        Px_LowerRight = gameObject.transform.Find("Borders/PixelSpace/Px-LowerRight").position;

        origin = gameObject.transform.Find("Borders/PixelSpace").position;
        h = gameObject.transform.Find("Borders/PixelSpace").eulerAngles.y;
    }

    void Update()
    {
        Px_UpperLeft = gameObject.transform.Find("Borders/PixelSpace/Px-UpperLeft").position;
        Px_LowerLeft = gameObject.transform.Find("Borders/PixelSpace/Px-LowerLeft").position;
        Px_LowerRight = gameObject.transform.Find("Borders/PixelSpace/Px-LowerRight").position;

        Px_UpperLeft -= transform.root.position;
        Px_LowerLeft -= transform.root.position;
        Px_LowerRight -= transform.root.position;

        Px_UpperLeft *= unitMultiplier;
        Px_LowerLeft *= unitMultiplier;
        Px_LowerRight *= unitMultiplier;

        origin = gameObject.transform.Find("Borders/PixelSpace").position;
        origin -= transform.root.position;

        h = gameObject.transform.Find("Borders/PixelSpace").eulerAngles.y;
    }
}
