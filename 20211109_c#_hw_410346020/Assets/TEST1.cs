using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // HW4
        int h=0;
        Debug.Log("HW4 物件移動");

        Vector2Int playerPos = new Vector2Int(0,0);
        for(int i=1;i<6;i++)
        {
            
            transform.position += new Vector3(h, 0, 0);
            h+=2;
                      
            Debug.Log(playerPos);
            playerPos.x +=2;
        }

    }

    // Update is called once per frame
    void Update()
    {
    
        



    }
        
}


