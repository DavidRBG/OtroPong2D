using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speedRate = 10f;
    public GameObject jugador1;
    public GameObject jugador2;

    void Update()
    {
        Vector2 myMov = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {
            myMov += Vector2.up;
        }
        if (Input.GetKey(KeyCode.S))
        {
            myMov += Vector2.down;
        }

        jugador1.transform.Translate(myMov * Time.deltaTime * speedRate, Space.World);

        Vector2 myMov2 = Vector2.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            myMov2 += Vector2.up;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            myMov2 += Vector2.down;
        }
        jugador2.transform.Translate(myMov2 * Time.deltaTime * speedRate, Space.World);
    }
}
