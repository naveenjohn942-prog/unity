using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;  

public class arRayCastPlace : MonoBehaviour
{
    public ARRaycastManager raycastManager;
    public GameObject objectToPlace;

    private GameObject placedObject;
    public GameObject objectSecond;

    public Camera arCamera;

    private List<ARRaycastHit> hits = new List<ARRaycastHit>();

    public LayerMask layerMask;

    // Update is called once per frame
    void Update()
    {

        Ray ray = arCamera.ScreenPointToRay(Input.mousePosition);

        RaycastHit hitObject;

        if (Input.GetMouseButton(0))
        {

            if (Physics.Raycast(ray,out hitObject, 50f, layerMask)){
                Vector3 newPoint = hitObject.point;
                Instantiate(objectSecond, newPoint, Quaternion.identity);
            }

            else if(raycastManager.Raycast(ray, hits, TrackableType.PlaneWithinPolygon))
            {
                Pose hitPose = hits[0].pose;
                if(placedObject == null)
                { 
                    placedObject = Instantiate(objectToPlace, hitPose.position, hitPose.rotation); 
                }
                else
                {
                    placedObject.transform.position = hitPose.position;
                    placedObject.transform.rotation = hitPose.rotation;
                }


            }
        }
        
    }
}
