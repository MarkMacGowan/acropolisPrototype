using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildingManager : MonoBehaviour
{   
    
    public RaycastPlane raycastPlane;
    public GameObject testBuilding;
    //public addBuildingBtn addBuildingBtn;
   // add public button variable below here
   // public 
    Vector3 placementCoord;
    

    private void Awake()
    {
        raycastPlane = GetComponent<RaycastPlane>();
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        placementCoord = raycastPlane.gamePosition;
    }


    public void addBuilding()
    {   
        // add if statement to check button is clicked
        
        Instantiate(testBuilding,placementCoord,Quaternion.identity);
      
    }


}
