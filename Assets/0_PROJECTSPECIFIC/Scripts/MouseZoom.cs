using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseZoom : MonoBehaviour
{
    public float FOV = 60.0f;
    public float min = 20.0f;
    public float max = 120.0f;
    public float factor = 1.0f;

    // Update is called once per frame
    void Update()
    {
        Camera.main.fieldOfView = FOV;
    }

    private void OnGUI()
    {
        FOV += Input.mouseScrollDelta.y * factor;
        float clamped = Mathf.Clamp(FOV, min, max);
        FOV = clamped;
    }
}
