using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public Sprite [ ]icon;
    public int[,] box = new int[3, 3];
    public int flag = 0 ;
    public GameObject Result;
	void Start () {
        int[,] box = new int[3, 3];//設定九宮格

        //判斷輸贏

        if ((box [0,0]==1 && box[0,1]==1 && box [0,2]==1) || 
               (box [1,0]==1 && box [1,1]==1 && box [1,2]==1)||
               (box[2, 0] == 1 && box[2, 1] == 1 && box[2, 2] == 1) ||
               (box[0, 0] == 1 && box[1, 0] == 1 && box[2, 0] == 1) ||
               (box[0, 1] == 1 && box[1, 1] == 1 && box[2, 1] == 1) ||
               (box[0, 2] == 1 && box[1, 2] == 1 && box[2, 2] == 1) ||
               (box[0, 0] == 1 && box[1, 1] == 1 && box[2, 2] == 1) ||
               (box[2, 0] == 1 && box[1, 1] == 1 && box[0, 2] == 1) )
            {
                
                Debug.Log("O Win!!");
        }
            else if ((box[0, 0] == 2 && box[0, 1] == 2 && box[0, 2] == 2) ||
               (box[1, 0] == 2 && box[1, 1] == 2 && box[1, 2] == 2) ||
               (box[2, 0] == 2 && box[2, 1] == 2 && box[2, 2] == 2) ||
               (box[0, 0] == 2 && box[1, 0] == 2 && box[2, 0] == 2) ||
               (box[0, 1] == 2 && box[1, 1] == 2 && box[2, 1] == 2) ||
               (box[0, 2] == 2 && box[1, 2] == 2 && box[2, 2] == 2) ||
               (box[0, 0] == 2 && box[1, 1] == 2 && box[2, 2] == 2) ||
               (box[2, 0] == 2 && box[1, 1] == 2 && box[0, 2] == 2) )
            {
                Debug.Log( "X Win!!!");
        }

     
    }

	
	// Update is called once per frame
	void Update () {
		
	}
}
