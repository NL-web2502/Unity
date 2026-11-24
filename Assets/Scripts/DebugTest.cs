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
       Debug.DrawLine(Vector3.zero, new Vector3 (5,4,0));

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
