using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupmask : MonoBehaviour
{
   public Transform grabDetect;
   public Transform maskHolder;
   public float rayDist;
   void Update(){
       RaycastHit2D grabCheck = Physics2D.Raycast(grabDetect.position, Vector2.right * transform.localScale, rayDist);

       if(grabCheck.collider != null && grabCheck.collider.tag == "Mask"){
               grabCheck.collider.gameObject.transform.parent = maskHolder;
               grabCheck.collider.gameObject.transform.position = maskHolder.position;
               grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
           
           
       }
   }
}
