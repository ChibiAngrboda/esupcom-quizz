using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Player : MonoBehaviour
{
    bool isGamePaused= false;
    List<string> teams;
    int whoPaused;
    public GameObject teamHolder;
    List<GameObject> teamsList = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
       foreach(Transform team in teamHolder.transform)
        {
            teamsList.Add(team.gameObject);
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
        if(Input.GetButton("P1"))
        {
            GreatQuestion();
        }
        if (Input.GetButton("P2"))
        {
            ResetQuestion();
        }
    }
    void TeamPause(int teamNumber)
    {
        if(isGamePaused)
        {
            return;
        }
        whoPaused = teamNumber - 1;
        teamsList[whoPaused].GetComponent<SpriteRenderer>().color = Color.yellow;
        
        isGamePaused = true;
    }
    private void ResetQuestion()
    {
        foreach(GameObject teamIcon in teamsList)
        {
            teamIcon.GetComponent<SpriteRenderer>().color = Color.white;
        }
        isGamePaused = false;
    }
    private void GreatQuestion()
    {
        teamsList[whoPaused].GetComponent<SpriteRenderer>().color = Color.green;
        isGamePaused = false ;
    }
}
