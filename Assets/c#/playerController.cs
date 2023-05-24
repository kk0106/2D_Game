using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playerController : MonoBehaviour
{
    public float speed=0.1f;
    public Rigidbody2D rb;
    public int hp = 0;
    public GameObject bu1;
    public int hpmax;
    public Image hp_bar;
    // Start is called before the first frame update
    void Start()
    {
        hpmax = 10;
        hp = hpmax;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.gameObject.transform.position += new Vector3(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.gameObject.transform.position -= new Vector3(speed, 0, 0);
        }
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bu1, this.transform.position, Quaternion.identity);
        }

        hp_bar.transform.localScale = new Vector3((float)hp / (float)hpmax, hp_bar.transform.localScale.y, hp_bar.transform.lossyScale.z);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "covid")
        {
            hp -= 1;
        }
    }
}
