using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{
 public float zoom= 0.01f;
   public Camera cameraComponent;
    // Start is called before the first frame update
    void Start()
    {
        //cameraComponent=GetComponent<Camera>();
     //   Or directly drag and drop

    }

    // Update is called once per frame
    void Update()
    {
        camerasize();
    }


    void camerasize(){

    if (Input.GetKey(KeyCode.I)){
       cameraComponent.orthographicSize +=zoom;
        }


          if (Input.GetKey(KeyCode.L)){
       cameraComponent.orthographicSize -=zoom;
        }

    }
}
