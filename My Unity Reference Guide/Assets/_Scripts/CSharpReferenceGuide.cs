using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSharpReferenceGuide : MonoBehaviour
{
	private int myAge = 25;

	private string name = "Alex Pinedo";

	private float weight = 100.3f;

	private bool isBoy = false;
	
	// Use this for initialization
	void Start () {
		ShowInfo();
		float myWeight = WeightSubtracter(weight);
		Debug.Log(myWeight);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Space)  )
			Debug.Log("You are pressing space");
	}

	void ShowInfo(int age = 10)
	{
		Debug.Log("Hello my name is " + name);
		Debug.Log("My name is " + age);

		for (int i = 0; i < 10; i = i + 2)
		{
			Debug.Log(i);
		}
		
		int iterator = 0;
		while (!isBoy) //other way of saying isBoy == false
		{
			Debug.Log("HELLO HELLO HELLO");
			if (iterator == 3)
				isBoy = true;
			iterator++;  //other way of saying i = i + 1
 
		}
		
	}

	float WeightSubtracter(float weight)
	{
		float newWeight = 0.0f;
		newWeight = weight - 10.2f;
		
		if (isBoy && myAge == 25)
		{
			Debug.Log("Its a boy!!");
		}
		
		if(isBoy && newWeight >= 50)
			Debug.Log("Pretty heavy");	//if you only have 1 statement you can write it this way
		else if (isBoy == false && newWeight >= 50)
		{
			Debug.Log("You're perfect :D");
		}
		else
		{
			Debug.Log("Eat more");
		}
		return newWeight;
	}
	
	
}
