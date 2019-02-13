using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Rotate_joystick : MonoBehaviour,IPointerDownHandler,IPointerUpHandler,IDragHandler {

	public Image bgImg, jsImg;
	public static Vector3 InputDirection;
	public GameObject player;
	public GameObject projectile;



	private void Start()
	{
		bgImg = GetComponent<Image>();
		jsImg = GetComponentsInChildren<Image>()[1];
		InputDirection = Vector3.zero;

	}

	public virtual void OnDrag(PointerEventData ped)
	{
		Vector2 pos = Vector2.zero;
		if (RectTransformUtility.ScreenPointToLocalPointInRectangle
			(   bgImg.rectTransform,
				ped.position,
				ped.pressEventCamera,
				out pos))
		{
			pos.x = (pos.x / bgImg.rectTransform.sizeDelta.x);
			pos.y = (pos.y / bgImg.rectTransform.sizeDelta.y);

            Debug.Log(pos);
            //      float x = (bgImg.rectTransform.pivot.x == 1) ? pos.x * 2 + 1 : pos.x * 2 - 1;
            //	float y = (bgImg.rectTransform.pivot.y == 1) ? pos.y * 2 + 1 : pos.y * 2 - 1;
            float x = pos.x * 2;
            float y = pos.y * 2;
            InputDirection = new Vector3(x, 0, y);
			InputDirection = (InputDirection.magnitude > 1) ? InputDirection.normalized : InputDirection;
			jsImg.rectTransform.anchoredPosition = new Vector3(InputDirection.x * (bgImg.rectTransform.sizeDelta.x/2 )
				, InputDirection.z * (bgImg.rectTransform.sizeDelta.y/2));
			player.transform.rotation = Quaternion.LookRotation(Rotate_joystick.InputDirection-Vector3.zero);
		}
	}
	public virtual void OnPointerDown(PointerEventData ped)
	{
		OnDrag(ped);
	}
	public virtual void OnPointerUp(PointerEventData ped)
	{
		Instantiate( projectile,player.transform.GetChild(0).transform.position,Quaternion.LookRotation(Rotate_joystick.InputDirection-Vector3.zero));
		InputDirection = Vector3.zero;
		jsImg.rectTransform.anchoredPosition3D = Vector2.zero;
	
	}


}
