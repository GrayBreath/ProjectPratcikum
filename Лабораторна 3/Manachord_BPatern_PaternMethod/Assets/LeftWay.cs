using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftWay : Patern
{

    // Use this for initialization
    public override IEnumerator differ()
    {

        InstLeft();
        yield return new WaitForSeconds(0.6f);
        InstUp();
        yield return new WaitForSeconds(0.6f);
        InstUp();
        yield return new WaitForSeconds(0.6f);
        InstRight();
        yield return new WaitForSeconds(0.6f);
        InstUp();
        yield return new WaitForSeconds(0.6f);
        current_Coord.x = 1; current_Coord.y = 0;
    }

    public void Build()
    {
        StartCoroutine(Building());
    }
    private void Update()
    {
    }

}
