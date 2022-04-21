using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

  public float xspeed= 0.01f;
  public float yspeed= 0.01f;
    // Start is called before the first frame update
    void Start()
    {
      //  print("This Works!");
    }

    // Update is called once per frame
    // FPS- frames per sec
    void Update()
    {
           move();
    }

  void move(){

    if (Input.GetKey(KeyCode.D)){
        transform.position += new Vector3(xspeed,0,0);
        }


         if (Input.GetKey(KeyCode.A)){
        transform.position -= new Vector3(xspeed,0,0);
        }


         if (Input.GetKey(KeyCode.W)){
        transform.position -= new Vector3(0,yspeed,0);
        }

   if (Input.GetKey(KeyCode.S)){
        transform.position += new Vector3(0,yspeed,0);
        }


  }   

  public void left(){
    
        
        transform.position -= new Vector3(xspeed,0,0);
        

  }
   public void right(){
   
        transform.position += new Vector3(xspeed,0,0);
       

   }
 public void top(){
   
   
        transform.position += new Vector3(0,yspeed,0);
   

 }
 public void down(){
    
        transform.position -= new Vector3(0,yspeed,0);
        
 }


}
