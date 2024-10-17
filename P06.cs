using System.Collections; using 
System.Collections.Generic; 
using UnityEngine;  
  
public class camerashake : MonoBehaviour { 
public Transform cameraTransform; private 
Vector3 _originalPosOfCam; public float 
shakeFrequency;   // Use this for 
initialization   void Start () {  
    _originalPosOfCam = cameraTransform.position;  
  }  
    
  // Update is called once per frame  
 void Update () {     if 
(Input.GetKey(KeyCode.S))  
    {  
       CameraShake();  
    }  
    else if(Input.GetKeyUp(KeyCode.S))  
    {  
      StopShake();  
    }     
}  
private void CameraShake()  
{  
  cameraTransform.position = _originalPosOfCam +  
Random.insideUnitSphere*shakeFrequency;  
}  
private void StopShake()  
{  
  cameraTransform.position = _originalPosOfCam;  
}  
}  
