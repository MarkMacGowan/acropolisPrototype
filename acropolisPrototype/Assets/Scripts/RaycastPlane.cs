using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastPlane : MonoBehaviour
{
    // have raycast use ui as mask
    Plane plane = new Plane(Vector3.down, 0);
    Ray ray;
    float distance;
    public Vector3 gamePosition;
    // Update is called once per frame
    public void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (plane.Raycast(ray, out  distance))
        {
            transform.position = ray.GetPoint(distance);
            Debug.Log(ray.GetPoint(distance));
            getRayPos();
        }
    }

    public void getRayPos()
    {
       gamePosition = ray.GetPoint(distance);
       Debug.Log("getRayPosMethod: " + gamePosition);
    }
}
