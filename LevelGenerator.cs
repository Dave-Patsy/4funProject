using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LevelGenerator : MonoBehaviour
{
    public GameObject background;
    private Vector2 position = new Vector2(0,0);
    private GameObject[] _backgroundTable;
    private int TableSize = 100;

    private RectTransform rt;

    private int rowSize = 10;
    private int rowCount = -1;
    private int colSize = 10;
    private int colCount = 0;

   



    // Start is called before the first frame update
    void Start()
    {

        _backgroundTable = new GameObject[TableSize];

        for(int i = 0; i < TableSize; i++)
        {
            if(  i%colSize == 0 )
            {
                rowCount++;
            }

            position.y = 3.97f * rowCount;
            position.x = 3.84f * colCount;

            _backgroundTable[i] = (GameObject)Instantiate(background, position, Quaternion.identity);

            colCount++;
            if(colCount == 10)
            {
                colCount = 0;
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
