using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
       int number =5 ;
       for (int i =1 ; i <= 10 ; i++){
       int resut =Mutiply (number, i);
       Debug.Log (number +"x" +i + "=" + resut);

       }
    }

   
     int Mutiply (int x, int y){
        int muliplynumbers = x*y;
         return muliplynumbers;
    }
}
