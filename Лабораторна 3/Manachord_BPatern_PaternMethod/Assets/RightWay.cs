using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightWay : Patern {
    public override IEnumerator differ()
    {
        InstRight();
        yield return new WaitForSeconds(0.6f);
        InstUp();
        yield return new WaitForSeconds(0.6f);
        InstUp();
        yield return new WaitForSeconds(0.6f);
        InstLeft();
        yield return new WaitForSeconds(0.6f);
        InstUp();
        yield return new WaitForSeconds(0.6f);
        current_Coord.x = 1; current_Coord.y = 0;

    }

    // Use this for initialization
    void Start () {
		
	}
	public void Build  ()
    {
        StartCoroutine(Building());
    }
	// Update is called once per frame
	void Update () {

        

    }
}
