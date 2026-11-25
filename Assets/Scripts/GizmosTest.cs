using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmosTest : MonoBehaviour
{
    private void OnDrawGizmos()
    {
           Gizmos.color = Color.red;
           Gizmos.DrawRay(transform.position, transform.forward);
    }

    private void OnDrawGizmosSelected()
    {
       // Gizmos.color = Color.green;
       // Gizmos.DrawSphere(Vector3.zero, 7f); 

    } 
}
