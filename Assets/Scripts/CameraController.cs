
using UnityEngine;

public class CameraController : MonoBehaviour {

	public float panSpeed = 20f;
	public float rotSpeed = 1f;

	//Update is called once per frame
	void Update(){

		Vector3 pos = transform.position;
		Quaternion rot = transform.rotation;

		//x-y-z movement
		if (Input.GetKey("w"))
		{
			pos.z += panSpeed * Time.deltaTime;	
		}
		if (Input.GetKey("s"))
		{
			pos.z -= panSpeed * Time.deltaTime;	
		}
		if (Input.GetKey("a"))
		{
			pos.x -= panSpeed * Time.deltaTime;	
		}
		if (Input.GetKey("d"))
		{
			pos.x += panSpeed * Time.deltaTime;	
		}		
		if (Input.GetKey("q"))
		{
			pos.y -= panSpeed * Time.deltaTime;	
		}
		if (Input.GetKey("e"))
		{
			pos.y += panSpeed * Time.deltaTime;	
		}

		//rotational movement
		if (Input.GetKey("i"))
		{
			rot.x -= rotSpeed * Time.deltaTime;	
		}
		if (Input.GetKey("k"))
		{
			rot.x += rotSpeed * Time.deltaTime;	
		}
		if (Input.GetKey("j"))
		{
			rot.y -= rotSpeed * Time.deltaTime;	
		}
		if (Input.GetKey("l"))
		{
			rot.y += rotSpeed * Time.deltaTime;	
		}


		transform.position = pos;
		transform.rotation = rot;
	}
}