using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Patern : MonoBehaviour
{
    public GameObject item;

    public bool isBuilding;
    public Vector3 current_Coord;
    
    public void InstUp()
    {
        current_Coord.y++;
        Destroy(Instantiate(item, current_Coord, item.transform.rotation), 10);

    }

    public void InstLeft()
    {
        current_Coord.x--;
     Destroy(Instantiate(item, current_Coord, item.transform.rotation),10);
    }

    public void InstRight()
    {
        current_Coord.x++;
        Destroy(Instantiate(item, current_Coord, item.transform.rotation), 10);
    }

    public abstract IEnumerator differ();
    public IEnumerator Building()
    {
        isBuilding = true;

        InstUp();
        yield return new WaitForSeconds(0.6f);
        StartCoroutine(differ());
        yield return new WaitForSeconds(0.6f);

  

    }


        

    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        
      
  
		

	}
}
