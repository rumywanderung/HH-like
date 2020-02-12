using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceManager : MonoBehaviour
{
    public List<GameObject> tileSequence;
    public GameObject tile1;
    public GameObject tile2;
    public GameObject tile3;
    public GameObject tile4;
    public GameObject tile5;
    public GameObject tile6;
    public GameObject tile7;
    public GameObject tile8;
    public GameObject tile9;
    public GameObject tile10;
    public GameObject tile11;
    public GameObject tile12;
    public GameObject tile13;
    public GameObject tile14;
    public GameObject tileCenter;

    bool playerTurn;
    bool nextColor;
    public GameObject player;

    int index;
    int sequenceNum;

    public void Start()
    {
        tileSequence = new List<GameObject>();
        tileSequence.Add(tile1);
        tileSequence.Add(tile2);
        tileSequence.Add(tile3);
        tileSequence.Add(tile4);
        tileSequence.Add(tile5);
        tileSequence.Add(tile6);
        tileSequence.Add(tile7);
        tileSequence.Add(tile8);
        tileSequence.Add(tile9);
        tileSequence.Add(tile10);
        tileSequence.Add(tile11);
        tileSequence.Add(tile12);
        tileSequence.Add(tile13);
        tileSequence.Add(tile14);
        tileSequence.Add(tileCenter);

        playerTurn = false;
        nextColor = false;

        sequenceNum = 3;
    }

    IEnumerator SwitchColors()
    {
        int j = Random.Range(0, 15);
        index = j;
        tileSequence[index].GetComponent<SpriteRenderer>().color = Color.red;
        yield return new WaitForSeconds(2F);
        Debug.Log("switch colors 2 seconds later");
        nextColor = false;
    }

    void Update()
    {
        if (playerTurn == false) //STOP PLAYER FROM MOVING
        {
            for (int i = 0; i < 15; i++)
            {
                tileSequence[i].gameObject.tag = "tile";
            }
            if (nextColor == false)
                {
                if (sequenceNum > 0)
                {
                    nextColor = true;
                    Debug.Log("Update coroutine");
                    tileSequence[index].GetComponent<SpriteRenderer>().color = Color.white;
                    StartCoroutine("SwitchColors");
                    sequenceNum -= 1;
                }
                else
                {
                    Debug.Log("Sequence over");
                    playerTurn = true;
                }    
                    
                }
        } 
    }
}
