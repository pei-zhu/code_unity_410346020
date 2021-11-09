using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Hw1
        Debug.Log("HW1：請用 for 迴圈，印出 5,4,3,2");
        
        for(int i=5;i>1;i--)
        {
            Debug.Log(i);
        }
        
        //Hw2
        Debug.Log("HW2：請用 for 迴圈 ﹐ 印出由 0 加到 20 的總和");
        
        int sum=0;
        
        for(int j=0;j<21;j++)
        {
            sum+=j;
        }
        
        Debug.Log(sum);

        //Hw3
        Debug.Log("HW3：請將計算陣列的平均值，由正整數改成浮點數");
        
        int[] p ={83, 99, 52, 93, 15};
        float s = 0f;
        
        for(int k=0;k<p.Length;k++)
        {
            s+=p[k];
        }
        
        float ave = s/p.Length;
        Debug.Log(ave);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
