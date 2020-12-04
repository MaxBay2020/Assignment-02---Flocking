using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllUnits : MonoBehaviour {

	public GameObject[] units;
	public GameObject unitPrefab;
	public int numUnits = 100;
	public Vector3 range = new Vector3(10,10,10);

    public bool seekGoal = true;
    public bool obedient = true;
    public bool willful = false;

    [Range(0, 200)]
    public int neighbourDistance = 70;

    [Range(0, 100)]
    public float maxforce = 20f;

    [Range(0, 5)]
    public float maxvelocity = 0f;

  //  void OnDrawGizmosSelected() 
 	//{
	 //	Gizmos.color = Color.red;
  //      Gizmos.DrawWireCube(this.transform.position, range*2);
  //      Gizmos.color = Color.green;
  //      Gizmos.DrawWireSphere(this.transform.position, 0.2f);

  //  }

	// initialization
	void Start () {
		units = new GameObject[numUnits];
		for(int i = 0; i < numUnits; i++)
		{
			Vector3 unitPos = new Vector3(Random.Range(-range.x,range.x),
											Random.Range(-range.y,range.y),
											Random.Range(0,0));
			units[i] = Instantiate(unitPrefab,this.transform.position + unitPos, Quaternion.identity) as GameObject;
			units[i].GetComponent<Unit>().manager = this.gameObject;
		}

	}
}
