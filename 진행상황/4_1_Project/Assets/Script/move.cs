using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public int Speed;
    public Transform Player1P, Player2P;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Player1P != null && Player2P != null)
        {
            Player1P.Translate(Vector3.forward * 5 * Time.deltaTime);
            Player2P.Translate(Vector3.forward * 5 * Time.deltaTime);
            if (Input.GetKey(KeyCode.A))
            {
                Player1P.Translate(Vector3.left * Speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                Player1P.Translate(Vector3.right * Speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                Player2P.Translate(Vector3.left * Speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                Player2P.Translate(Vector3.right * Speed * Time.deltaTime);
            }
        }
        else
        {
            transform.Translate(Vector3.forward * 5 * Time.deltaTime);
        }
    }
}