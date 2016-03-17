﻿using UnityEngine;
using System.Collections;

public class InstantiateMATACells : MonoBehaviour {


	public Rigidbody cell;
	public Rigidbody smooze;
	public Rigidbody largeBudded;
	public Rigidbody mitosis;
	public Rigidbody smallBudded;
	public GameObject top;
	public GameObject bottom;
	public GameObject right;
	public GameObject left;
	public GameObject other;
	public GameObject[] allCells;
	public OtherSlider sliderScript;
	public Vector3 pos;
	public Quaternion rotation;
	public int cellStartAmount = 50;
	public int roundCells0 = 0;
	public int schmooedCells0 = 0;
	public int buddedCells0 = 0;
	public int roundCells90 = 0;
	public int schmooedCells90 = 0;
	public int buddedCells90 = 0;
	public int roundCells180 = 0;
	public int schmooedCells180 = 0;
	public int buddedCells180 = 0;
	public int roundCells270 = 0;
	public int schmooedCells270 = 0;
	public int buddedCells270 = 0;
	public int roundCells360 = 0;
	public int schmooedCells360 = 0;
	public int buddedCells360 = 0;
	private float time = 0;
	private float tempTime = 0;

	// Use this for initialization
	void Start () {
		//createCells();
		rotation = Quaternion.Euler (-90, 0, 0);
		roundCells0 = Mathf.RoundToInt (.83f * cellStartAmount); //83% cell, 5% schmooed, 12% budded
		schmooedCells0 = Mathf.RoundToInt (.05f * cellStartAmount);
		buddedCells0 = Mathf.RoundToInt (.12f * cellStartAmount);

		roundCells90 = Mathf.RoundToInt (.49f * cellStartAmount); //49% cell, 37% schmooed, 14% budded
		schmooedCells90 = Mathf.RoundToInt (.37f * cellStartAmount);
		buddedCells90 = Mathf.RoundToInt (.14f * cellStartAmount);

		roundCells180 = Mathf.RoundToInt (.20f * cellStartAmount); //20% cell, 64% schmooed, 16% budded
		schmooedCells180 = Mathf.RoundToInt (.64f * cellStartAmount);
		buddedCells180 = Mathf.RoundToInt (.16f * cellStartAmount);

		roundCells270 = Mathf.RoundToInt (.13f * cellStartAmount); //13% cell, 85% schmooed, 2% budded
		schmooedCells270 = Mathf.RoundToInt (.85f * cellStartAmount);
		buddedCells270 = Mathf.RoundToInt (.02f * cellStartAmount);


		roundCells360 = Mathf.RoundToInt (.14f * cellStartAmount);//14% cell, 83% schmooed, 3% budded
		schmooedCells360 = Mathf.RoundToInt (.83f * cellStartAmount);
		buddedCells360 = Mathf.RoundToInt (.03f * cellStartAmount);

		sliderScript = other.gameObject.GetComponent<OtherSlider>();
		time = sliderScript.getTime ();
		tempTime = time;
	}
	
	// Update is called once per frame
	void Update () {
		time = sliderScript.getTime ();
		if (tempTime != time) {
			for(int i = 0 ; i < allCells.Length ; i ++)
			{
				Destroy(allCells[i]);
			}
			tempTime = time;
			if(tempTime == 0f)
			{

				createCells0();
			}
			else if(tempTime == 90f)
			{
				createCells90();
			}
			else if(tempTime == 180f)
			{
				createCells180();
			}
			else if(tempTime == 270f)
			{
				createCells270();
			}
			else if(tempTime == 360f)
			{
				createCells360();
			}
		}
		allCells = GameObject.FindGameObjectsWithTag ("Cell");
	}
	void createCells()
	{
		for (int i = 1; i < cellStartAmount; i++) {
			//						x																	y										z
			//pos = new Vector3 (Random.Range(left.transform.position.x, right.transform.position.x), Random.Range(bottom.transform.position.y, top.transform.position.y), -4.83f );
			pos = new Vector3 (Random.Range(left.transform.position.x, right.transform.position.x), 0f , Random.Range(bottom.transform.position.z, top.transform.position.z));
			Instantiate(cell, pos, rotation);
		}

	}
	//Mat A
	void createCells0() 
	{
		if (roundCells0 != 0) {
			createRound(roundCells0);
		}

		if (schmooedCells0 != 0) {
			createSchmooed(schmooedCells0);
		}

		if (buddedCells0 != 0) {
			createBudded(buddedCells0);
		}
	}
	void createCells90() 
	{
		if (roundCells0 != 0) {
			createRound(roundCells90);
		}
		
		if (schmooedCells0 != 0) {
			createSchmooed(schmooedCells90);
		}
		
		if (buddedCells0 != 0) {
			createBudded(buddedCells90);
		}
	}
	void createCells180() 
	{
		if (roundCells0 != 0) {
			createRound(roundCells180);
		}
		
		if (schmooedCells0 != 0) {
			createSchmooed(schmooedCells180);
		}
		
		if (buddedCells0 != 0) {
			createBudded(buddedCells180);
		}
	}
	void createCells270() 
	{
		if (roundCells0 != 0) {
			createRound(roundCells270);
		}
		
		if (schmooedCells0 != 0) {
			createSchmooed(schmooedCells270);
		}
		
		if (buddedCells0 != 0) {
			createBudded(buddedCells270);
		}
	}
	void createCells360() 
	{
		if (roundCells0 != 0) {
			createRound(roundCells360);
		}
		
		if (schmooedCells0 != 0) {
			createSchmooed(schmooedCells360);
		}
		
		if (buddedCells0 != 0) {
			createBudded(buddedCells360);
		}
	}
	void createRound(int number)
	{
		for (int i = 1; i < number; i++) {
			
			pos = new Vector3 (Random.Range (left.transform.position.x, right.transform.position.x), 0f, Random.Range (bottom.transform.position.z, top.transform.position.z));
			Instantiate (cell, pos, rotation);
		}
	}
	void createSchmooed(int number)
	{
		for (int i = 1; i < number; i++) {
			
			pos = new Vector3 (Random.Range (left.transform.position.x, right.transform.position.x), 0f, Random.Range (bottom.transform.position.z, top.transform.position.z));
			Instantiate (smooze, pos, rotation);
		}
	}
	void createBudded(int number) //Still need to change each cell in which stage it is budded
	{
		for (int i = 1; i < number; i++) {
			
			pos = new Vector3 (Random.Range (left.transform.position.x, right.transform.position.x), 0f, Random.Range (bottom.transform.position.z, top.transform.position.z));
			Instantiate (smallBudded, pos, rotation);
		}
	}

}
