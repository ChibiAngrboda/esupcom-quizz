using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Player : MonoBehaviour
{
    bool isGamePaused;
    List<string> teams;
    string whoPaused;
    GameObject teamHolder;
    List<GameObject> teamsList;


    // Start is called before the first frame update
    void Start()
    {
       foreach(GameObject team in teamHolder)
        {
            teamsList.Add(team);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("T1"))
        {TeamPause(1);}
        if (Input.GetButton("T2"))
        {TeamPause(2);}
        if (Input.GetButton("T3"))
        { TeamPause(3); }
        if (Input.GetButton("T4"))
        { TeamPause(4); }
        if (Input.GetButton("T5"))
        { TeamPause(5); }
        if (Input.GetButton("T6"))
        { TeamPause(6); }
        if (Input.GetButton("T7"))
        { TeamPause(7); }
        if (Input.GetButton("T8"))
        { TeamPause(8); }
        if (Input.GetButton("T9"))
        { TeamPause(9); }
        if (Input.GetButton("T10"))
        { TeamPause(10); }
        if (Input.GetButton("T11"))
        { TeamPause(11); }
        if (Input.GetButton("T12"))
        { TeamPause(12); }
        if (Input.GetButton("T13"))
        { TeamPause(13); }
        if (Input.GetButton("T14"))
        { TeamPause(14); }
    }
    void TeamPause(int teamNumber)
    {
        teamsList.
    }
}
