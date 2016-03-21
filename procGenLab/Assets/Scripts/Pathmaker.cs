using UnityEngine;
using System.Collections;

public class Pathmaker : MonoBehaviour {

	private int counter = 0;
	public Transform floorPrefab1; 
	public Transform floorPrefab2; 
	public Transform floorPrefab3; 
	public Transform pathmakerPrefab;
	Transform tempFloor;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(counter < 50){
			//Gen for pathmaker and rotates
			float randomNumber = Random.Range(0f,1f);
			if(randomNumber < 0.25f){
				transform.Rotate(new Vector3(0, 90, 0));
			}

			if(randomNumber >= 0.25f && randomNumber < 0.50f){
				transform.Rotate(new Vector3(0, -90, 0));
			}

			if(randomNumber >= 0.99f && randomNumber <= 1f){
				Object clone = Instantiate(pathmakerPrefab, transform.position, Quaternion.identity);
				//transform.position += transform.forward * Time.deltaTime * 5;
			}

			//Choosing what tile to spawn
			randomNumber = Random.Range(0f,1f);
			if(randomNumber <= 0.20f){
				tempFloor = floorPrefab1;
			}
			else if(randomNumber > 0.20f && randomNumber <= 0.60F){
				tempFloor = floorPrefab2;
			}
			else if(randomNumber > 0.60F){
				tempFloor = floorPrefab3;
			}
			//Choosing height to spawn at

			Object temp = Instantiate(tempFloor, transform.position, Quaternion.identity);
			transform.position += transform.forward * 5;
			counter++;

		}
	
		else{
			Destroy(this);
		}
	}
}
