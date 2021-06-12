using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class FileWriter : MonoBehaviour {
	public static FileWriter Instance;
	public String fileName;
	StreamWriter outStream;
	public string[] Title;


	void Awake ()
	{
		if(Instance == null){
			Instance = this;
		}
	}

	// Use this for initialization
	void Start () {
		fileName = String.Format("{0:yyyyMMdd-HHmmss}.csv", DateTime.Now);
		outStream = System.IO.File.CreateText(fileName);
		outStream.Write("Time");
		for (int i=0;i<Title.Length;i++){
			outStream.Write(","+Title[i]);
		}
		outStream.WriteLine();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}

	public void WriteFile(String str){
        outStream.WriteLine(Time.time+","+str);
		outStream.Flush();
	}

	void OnDisable(){
        outStream.Close();//The file will be saved under the project folder
	}
}
