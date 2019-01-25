using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour {
    public GameObject Core;
    public int row;
    public int col;
    public int f;  //box自己的點擊順序
    public GameObject Result;
	
	void Start () {

	}

	void Update () {
      
    }
    void OnMouseDown()
    {
        int[,] box = Core.GetComponent<GameController>().box;
        int flag = Core.GetComponent<GameController>().flag; //決定玩家


        //兩個玩家順序，點擊過的box不能再點擊
        if (flag % 2 == 0)
        {
            if (f == 0)
            {
                Core.GetComponent<GameController>().box[row, col] = 1;
                Core.GetComponent<GameController>().flag += 1;
                f = 1;
            }
        }

        else if (flag % 2 != 0)
        {
            if (f == 0)
            {
                Core.GetComponent<GameController>().box[row, col] = 2;
                Core.GetComponent<GameController>().flag += 1;

                f = 1;
            }
        }

        //設定顯示box裡的icon
        if (box[row, col] == 1)
        {
            GetComponent<SpriteRenderer>().sprite = Core.GetComponent<GameController>().icon[0];
        }
        else if (box[row, col] == 2)
        {
            GetComponent<SpriteRenderer>().sprite = Core.GetComponent<GameController>().icon[1];
        }

        //顯示輸贏

        if ((box[0, 0] == 1 && box[0, 1] == 1 && box[0, 2] == 1) ||
         (box[1, 0] == 1 && box[1, 1] == 1 && box[1, 2] == 1) ||
         (box[2, 0] == 1 && box[2, 1] == 1 && box[2, 2] == 1) ||
         (box[0, 0] == 1 && box[1, 0] == 1 && box[2, 0] == 1) ||
         (box[0, 1] == 1 && box[1, 1] == 1 && box[2, 1] == 1) ||
         (box[0, 2] == 1 && box[1, 2] == 1 && box[2, 2] == 1) ||
         (box[0, 0] == 1 && box[1, 1] == 1 && box[2, 2] == 1) ||
         (box[2, 0] == 1 && box[1, 1] == 1 && box[0, 2] == 1))
        {

            Result.GetComponent<TextMesh>().text = " O Win!! ";
            Color32 color = new Color32(168, 253, 247, 255);
            Result.GetComponent<TextMesh>().color = new Color32(168, 253, 247, 255);

        }
        else if ((box[0, 0] == 2 && box[0, 1] == 2 && box[0, 2] == 2) ||
           (box[1, 0] == 2 && box[1, 1] == 2 && box[1, 2] == 2) ||
           (box[2, 0] == 2 && box[2, 1] == 2 && box[2, 2] == 2) ||
           (box[0, 0] == 2 && box[1, 0] == 2 && box[2, 0] == 2) ||
           (box[0, 1] == 2 && box[1, 1] == 2 && box[2, 1] == 2) ||
           (box[0, 2] == 2 && box[1, 2] == 2 && box[2, 2] == 2) ||
           (box[0, 0] == 2 && box[1, 1] == 2 && box[2, 2] == 2) ||
           (box[2, 0] == 2 && box[1, 1] == 2 && box[0, 2] == 2))
        {
            Result.GetComponent<TextMesh>().text = " X Win!! ";
            Color32 color = new Color32(247, 158, 253, 255);
            Result.GetComponent<TextMesh>().color = new Color32(247, 158, 253, 255);
        }


    }
}
