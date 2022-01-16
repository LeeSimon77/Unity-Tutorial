using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    private Rigidbody2D body;
    public Collider2D deathbox;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float multiplier = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(multiplier * 7f, body.velocity.y);

        if(Input.GetButtonDown("Jump"))
        {
            body.velocity = new Vector2(body.velocity.x, 14);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision = deathbox)
        {
            Debug.Log("End Game");
            //UnityEditor.EditorApplication.isPlaying = false;
            Application.Quit();
        }
    }
}
