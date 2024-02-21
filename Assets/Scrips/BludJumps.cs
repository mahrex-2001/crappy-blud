using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BludJumps : MonoBehaviour
{
    private Rigidbody2D rb;
    private CapsuleCollider2D csd;
    [SerializeField] private float jumpForce = 5f;

    public LogicManager logic;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        csd = GetComponent<CapsuleCollider2D>();

        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();

    }

    // Update is called once per frame
    void Update()
    {
        // player jumps by hitting space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpBlud();
        }
        
    }

    // jumping method
    private void jumpBlud()
    {
        rb.velocity = Vector2.up * jumpForce;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOverScene();

        Destroy(gameObject);
    }
}
