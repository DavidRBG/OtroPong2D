using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Bounce : MonoBehaviour
{
    public float speedRate = 10f;
    public GameObject ball;
    public GameObject gameScreen;
    Vector2 myMov4 = Vector2.zero;
    public TextMeshProUGUI goal1;
    public TextMeshProUGUI goal2;
    public int goals1;
    public int goals2;

    void Start()
    {
        if (gameScreen.activeSelf == true)
        {
            myMov4 = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1f, 1f)); //Vector velocidad inicial de la pelota
        }
    }
    void Update()
    {
        ball.transform.Translate(myMov4.normalized * Time.deltaTime * speedRate, Space.World); //cambio del vector velocidad con respecto al tiempo

        goal1.text = goals1.ToString();
        goal2.text = goals2.ToString();
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag == "Wall") //acciones de la pelota al chocar con una pared
        {
            myMov4.y = (-myMov4.y);
        }

        if (other.gameObject.tag == "Goal1") //cuando se marca un gol en la porteria 1
        {
            goals2++;
            transform.position = new Vector2(0, 0);
            myMov4 = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1f, 1f)); 
        }

        if (other.gameObject.tag == "Goal2")//cuando se marca un gol en la porteria 2
        {
            goals1++;
            transform.position = new Vector2(0, 0);
            myMov4 = new Vector2(Random.Range(-1.0f, 1.0f - 0), Random.Range(-1f, 1f - 0)); 
        }

        if (other.gameObject.tag == "Pallet") //acciones de la pelota al chocar con una raqueta
        {
            myMov4.x = (-myMov4.x);
            myMov4.y = (-myMov4.y);


        }
    }
}
