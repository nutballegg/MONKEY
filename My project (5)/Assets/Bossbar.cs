using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Bossbar : MonoBehaviour
{
    public Image bar;
    public float bhp = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("o"))
        {
            dmg(5);
        }
        if (Input.GetKeyDown("p"))
        {
            heal(5);
        }
    }

    public void dmg(float dam)
    {
        bhp -= dam;
        if (bhp < 0) { bhp = 0; }
        bar.fillAmount = bhp / 100f;
    }
    public void heal(float heal)
    {
        bhp += heal;
        if (bhp > 100) { bhp = 100; }
        bar.fillAmount = bhp / 100f;
    }
}
