using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    [SerializeField]float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        GiveInstructions();   
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }
    void GiveInstructions(){
        Debug.Log("WELCOME");
        Debug.Log("MOVE PLAYER AND DONT CRASH THE WALLS");
    }
    void MovePlayer(){
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,0,zValue);
    }
}
