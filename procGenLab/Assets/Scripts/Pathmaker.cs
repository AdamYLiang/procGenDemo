using UnityEngine;
using System.Collections;

public class Pathmaker : MonoBehaviour {

	private int counter = 0;
	public Transform floorPrefab; 
	public Transform pathmakerPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(counter < 50){
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
				transform.position += transform.forward * 5;
				counter++;
			}

		}
	
		else{
			Destroy(this);
		}
	}
}
