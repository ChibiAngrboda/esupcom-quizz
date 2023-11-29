using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGenerator : MonoBehaviour
{
    public GameObject team;
    public GameObject player;
    public int number;
    public float distance;
    public float scaleX;
    public float scaleY;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < number; i++)
        {
            Instantiate(team, player.transform.position + Quaternion.Euler(scaleX*90-90, scaleY*90-90, 20 * i) * new Vector3(0, -distance, 0) , transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
