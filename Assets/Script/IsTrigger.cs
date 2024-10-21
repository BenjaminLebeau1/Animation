using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsTrigger : MonoBehaviour
{
    // Start is called before the first frame update
[SerializeReference] Animator door;
    // Update is called once per frame
   private void OnTriggerEnter(Collider other)
    {
      if(other.CompareTag("Player"))
      {
        print("Open Door!");
        door.SetBool("IsOpen", true);
      }  
    }

     private void OnTriggerExit(Collider other)
    {
      if(other.CompareTag("Player"))
      {
        print("Close Door!");
        door.SetBool("IsOpen", false);
      }  
    }
}
