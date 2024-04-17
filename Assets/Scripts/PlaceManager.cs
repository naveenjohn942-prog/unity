using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlaceManager : MonoBehaviour
{

    private PlaceIndicator placeIndicator;
    // public GameObject objectToPlace;
    public GameObject ar1;
    public GameObject ar2;
    public GameObject ar3;
    public GameObject ar4;
    public GameObject ar5;


    public TriggerScript triggerScript;

    private GameObject newPlacedObject;
    List<GameObject> placedObjects;

// frankenstein

    //public AnimationScript animationScript;


    void Start()
    {
        placeIndicator = FindObjectOfType<PlaceIndicator>();
        placedObjects = new List<GameObject>();
    }


//     public void ClickToPlace()
//     {
//         //move back into if
// /*        placeIndicator.gameObject.SetActive(false);
//         panelOne.SetActive(false);
//         panelTwo.SetActive(true);*/

//         // frankenstein


//         // if (newPlacedObject == null)
//             {
//                 // newPlacedObject = Instantiate(objectToPlace, hitPose.position, hitPose.rotation);
//                 newPlacedObject = Instantiate(objectToPlace, placeIndicator.transform.position, placeIndicator.transform.rotation);
//         //         newPlacedObject = Instantiate(objectToPlace, placeIndicator.transform.position, Quaternion.identity);


//         //         //animationScript.animator = newPlacedObject.GetComponent<Animator>();

//         //         triggerScript.arActive();

//         }

//             //commented out because indicator is disabled after object insantiation
// /*            else
//             {
//                 newPlacedObject.transform.position = placeIndicator.transform.position;
//                 newPlacedObject.transform.rotation = placeIndicator.transform.rotation;
//             }*/

//         //}


//         // orig
//         // newPlacedObject = Instantiate(objectToPlace, placeIndicator.transform.position, placeIndicator.transform.rotation);



//         // if (newPlacedObject == null)
//         // {
//         //     // Use prefab rotation (if applicable)
//         //     if (objectToPlace.GetComponent<MeshRenderer>() != null) // Check if objectToPlace has a MeshRenderer (prefab indicator)
//         //     {
//         //         newPlacedObject = Instantiate(objectToPlace, placeIndicator.transform.position, objectToPlace.transform.rotation);
//         //     }
//         //     // Use model's local rotation (if applicable)
//         //     else
//         //     {
//         //         GameObject model = objectToPlace.transform.GetChild(0).gameObject;
//         //         newPlacedObject = Instantiate(objectToPlace, placeIndicator.transform.position, model.transform.localRotation);
//         //     }


//         // }

//     }



public void ClickToPlace(GameObject objectToPlace)
{

    // if (newPlacedObject == null)
        {


        //newPlacedObject = Instantiate(objectToPlace, hitPose.position, hitPose.rotation);
        newPlacedObject = Instantiate(objectToPlace, placeIndicator.transform.position, objectToPlace.transform.rotation);
        placedObjects.Add(newPlacedObject); 

            // triggerScript.arActive();

    }


}



    public List<GameObject> GetNewPlacedObject()
    {
        return placedObjects;
    }

    public void AR1()
    {
        ClickToPlace(ar1);
    }

    public void AR2()
    {
        ClickToPlace(ar2);
    }

    public void AR3()
    {
        ClickToPlace(ar3);
    }

    public void AR4()
    {
        ClickToPlace(ar4);
    }



}
