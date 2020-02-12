using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody2D rb;
    Ray ray;
    bool moving;
    Vector3 dir;
   
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        moving = false;
        dir = new Vector3(-1.51F, -3.22F, 0);
    }

 

    void Update()
    {

        if (moving == true)
        {
            this.transform.position = Vector3.Lerp(this.transform.position, dir, 1F);
            moving = false;
        }
        

        #region mobile

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

            if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity) && hit.collider.gameObject.tag == "clickable")
            {
                
                moving = true;
                dir = hit.collider.gameObject.transform.position;
                dir.y += 0.5F;
                
            }
        }

        #endregion

        #region pc

        //Debug.Log(this.transform.position.x + "," + this.transform.position.y + "," + this.transform.position.z);

        if (Input.GetMouseButtonDown(0) == true)
        {
      

            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity))
            {
                

                if (hit.collider.gameObject.tag == "clickable")
                {
                   
                    moving = true;
                    dir = hit.collider.gameObject.transform.position;
                    dir.y += 0.5F;
                    
                }
            } 
        }
        #endregion
    }
}
