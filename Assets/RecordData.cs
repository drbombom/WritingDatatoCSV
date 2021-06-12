using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordData : MonoBehaviour {

	// Use this for initialization
	public FileWriter FW;
	public string Data;
	public bool Flag;
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Data = transform.position.x.ToString();
		Data += ","+transform.position.y.ToString();
		Data += ","+transform.position.z.ToString();
		Data += ","+Flag.ToString();
		FW.WriteFile(Data);//Write string Data as a line of data
	}
}
