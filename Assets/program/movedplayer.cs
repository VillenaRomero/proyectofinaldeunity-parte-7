using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movedplayer : NewBehaviourScript
{
    public float horizontal;
    public float vertical;
    public float speedx;
    public float speedy;
    private Rigidbody2D _compRigidbody2D;
    public GameObject bulletprefab;
    private void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        _compRigidbody2D.velocity = new Vector2(speedx * horizontal, speedy * vertical);
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Instantiate(bulletprefab, transform.position, transform.rotation);
        }
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("level2"))
        {
            SceneManager.LoadScene("playgame2");
        }
    }
}
