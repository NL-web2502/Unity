using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTest: MonoBehaviour
{
     private float _timer;
     private int _level;
     [SerializeField] private int _allCountLevel;

     private void Update()
    {
      if(Input.GetKeyDown(KeyCode.Space))
      {
        Debug.DrawLine(Vector3.zero, new Vector3(5,4,0), Color.green, 2.5f);
      } 
      Debug.DrawRay(new Vector3(-1,0,0), new Vector3 (5,4,0), Color.red);
    } 


    //private void GetLevel(int level)
    //{
   //     if(level<_allCountLevel && level>0)
   //     {
   //         _level = level;
   //     }
   //     else
   //     {
   //         Debug.LogError("Такого уровня нет!");
   //     }
   // }
}
