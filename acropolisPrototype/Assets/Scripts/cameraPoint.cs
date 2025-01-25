using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraPoint : MonoBehaviour
{
    public Camera camera;

    
    void Start()
    {
        
        


    }
    private void Update()
    {
      
      RaycastHit hit;
      Ray ray = camera.ScreenPointToRay(Input.mousePosition);

      if (Physics.Raycast(ray, out hit))
        {
            Transform objectHit = hit.transform;
            Debug.Log(hit.transform.position +" "+hit.transform.gameObject);
            
            // Do something with the object that was hit by the raycast.
        }
    }
}
