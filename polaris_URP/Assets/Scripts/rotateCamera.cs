using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.EventSystems;
using UnityEngine;

public class rotateCamera : MonoBehaviour
{
	[SerializeField]
	GameObject cam = null;

	public void leftSide()
    {
		cam.transform.eulerAngles = new Vector3(cam.transform.eulerAngles.x, cam.transform.eulerAngles.y - 90, cam.transform.eulerAngles.z);
	}

	public void rightSide()
	{
		cam.transform.eulerAngles = new Vector3(cam.transform.eulerAngles.x, cam.transform.eulerAngles.y + 90, cam.transform.eulerAngles.z);
	}

	void Update()
	{
		/*if(Input.GetMouseButton(0)) // 클릭한 경우
		{
			xRotateMove = -Input.GetAxis("Mouse Y") * Time.deltaTime * rotateSpeed;
			yRotateMove = Input.GetAxis("Mouse X") * Time.deltaTime * rotateSpeed;

			yRotate = transform.eulerAngles.y + yRotateMove;
			//xRotate = transform.eulerAngles.x + xRotateMove; 
			xRotate = xRotate + xRotateMove;
            
			xRotate = Mathf.Clamp(xRotate, -90, 90); // 위, 아래 고정
            
			transform.eulerAngles = new Vector3(xRotate, yRotate, 0);
			
			if (EventSystem.current.IsPointerOverGameObject())
			{
				Debug.Log("Clicked UI");
			}
			else
			{
				Debug.Log("Clicked Not UI");
			}
		}*/
	}

	void OnGUI()
	{
		/*
		float xMin_Right = (Screen.width * 11 / 12) - (ArrowSize / 2);
		float yMin_Right = (Screen.height * 5 / 6) - (ArrowSize / 2);
		GUI.DrawTexture(new Rect(xMin_Right, yMin_Right, ArrowSize, ArrowSize), Arrow_Right);

		float xMin_Left = (Screen.width / 12) - (ArrowSize / 2);
		float yMin_Left = (Screen.height * 5 / 6) - (ArrowSize / 2);
		GUI.DrawTexture(new Rect(xMin_Left, yMin_Left, ArrowSize, ArrowSize), Arrow_Left);
		*/
	}
}
