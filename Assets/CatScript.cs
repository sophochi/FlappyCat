using UnityEngine;
using UnityEngine.InputSystem;

public class CatScript : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public float jumpForce;
    public LogicScript logic;
    public bool isAlive = true;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && isAlive)
        {
            myRigidbody.linearVelocity = Vector2.up * jumpForce;
        }

        if (transform.position.y > 20 || transform.position.y < -20)
        {
            logic.gameOver();
            isAlive = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        isAlive = false;
    }
}
