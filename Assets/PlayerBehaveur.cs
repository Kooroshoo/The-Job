using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class PlayerBehaveur : MonoBehaviour { 

    public Flowchart flowchart;

    int x;

    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        //On KeyboardBottun Clicked or Mose moive Print Somthing
        PlayerMouseAndKeyboardMoveMent();

        
        Debug.Log(Input.mousePosition.x/1000);
        if (Input.mousePosition.x/1000 > 0.73)
        {
            if (x==0)
            {
                flowchart.ExecuteBlock("T1A2");
                x++;
            }
            else if (x==1)
            {
                flowchart.ExecuteBlock("T2A2");
                x++;
            }
            else if (x==2)
            {
                flowchart.ExecuteBlock("T3A3");
                x++;
            }
            


        }
        else
        {
            if (x==0)
            {
                    flowchart.ExecuteBlock("T1A1");
                    x++;
            }
            else if (x==1)
            {
                     flowchart.ExecuteBlock("T2A1");
                      x++;
            }
            else if (x==2)
            {
                     flowchart.ExecuteBlock("T2A3");
                     x++;
            }
            
        }

    }



    void PlayerMouseAndKeyboardMoveMent()
    {

        


        if (Input.GetAxis("Mouse X") < -2)
        {
            flowchart.ExecuteBlock("MouseL");
            Debug.Log("Left");
        }

        if (Input.GetAxis("Mouse X") > 2)
        {
            flowchart.ExecuteBlock("MouseR");
            Debug.Log("Right");
        }

        if (Input.GetAxis("Mouse Y") < -2)
        {
            flowchart.ExecuteBlock("MouseD");
            Debug.Log("down");
        }

        if (Input.GetAxis("Mouse Y") > 2)
        {
            flowchart.ExecuteBlock("MouseU");
            Debug.Log("UP");
        }

        if (Input.anyKeyDown)
        {
            if (Input.GetKey(KeyCode.Mouse0) || Input.GetKey(KeyCode.Mouse1))
            {
                flowchart.ExecuteBlock("MousePressed");
            }
            else
            {
                flowchart.ExecuteBlock("KeyBoardPressed");
            }
        }
    }


}
