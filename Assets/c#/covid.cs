using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class covid : MonoBehaviour
{
    public int hp = 0;
    public int hpmax = 0;
    public GameObject hp_bar;
    // Start is called before the first frame update
    void Start()
    {
        hpmax = 10;
        hp = hpmax;
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            Destroy(this.gameObject);
        }

        float _present=((float)hp / (float)hpmax);
        hp_bar.transform.localScale = new Vector3(_present, hp_bar.transform.localScale.y, hp_bar.transform.localScale.z);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "bu1")
        {
            hp -= 1;
            Destroy(other.gameObject);
        }
    }
}
