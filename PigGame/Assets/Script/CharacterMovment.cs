using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovment : MonoBehaviour
{
    public float playerSpeed_f;



    // Start is called before the first frame update 

    void Start()

    {

    }

    // Update is called once per frame 

    void Update()

    {
        Move();

        MoveUpDown();
    }

    void Move()

    {

        // 1. Get key presses 

        //2. On press A character should move left, 

        if (Input.GetKey(KeyCode.A))

        {
            transform.Translate(Vector3.left * Time.deltaTime * playerSpeed_f);
        }



        // On D press character should move right 

        else if (Input.GetKey(KeyCode.D))

        {
            transform.Translate(Vector3.right * Time.deltaTime * playerSpeed_f);

        }

    }

    void MoveUpDown()

    {
 //Press W to go up  

      if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * Time.deltaTime * playerSpeed_f);
        }



        //Goes down on D  

        else if (Input.GetKey(KeyCode.S))

        {
            transform.Translate(Vector3.down * Time.deltaTime * playerSpeed_f);
        }



    }
}