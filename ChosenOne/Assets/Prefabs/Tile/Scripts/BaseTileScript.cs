using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BaseTileScript : MonoBehaviour {

    public int hp { get; set; }
    public int magic { get; set; }
    public int attack { get; set; }
    public int magicDefense { get; set; }
    public int physicalDefense { get; set; }
    public int speed { get; set; }
    public List<int> attacks = new List<int>();
	// Use this for initialization
	void Start () {
        hp = 100;
	}
	
	// Update is called once per frame
	void Update ()
    {
        foreach (int i in attacks)
        {
            hp -= i * 2;
            Debug.Log("hp = " + this.hp);
        }

        attacks.Clear();

        if (hp <= 0)
            Destroy(this.gameObject);
	}

    public void addAttack(int attack)
    {
        attacks.Add(attack);
    }
}
