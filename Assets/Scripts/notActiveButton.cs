using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Scripts.Items;
public class notActiveButton : MonoBehaviour, IPointerClickHandler {


	public void OnPointerClick(PointerEventData eventData)
	{
		if (eventData.button == PointerEventData.InputButton.Left)
			button1 ();
		//Debug.Log ("Left click");
		else if (eventData.button == PointerEventData.InputButton.Right)
			button2 ();
		//Debug.Log ("Right Click");
	}

	public void button1()
	{
		Vector3 buttonPos = new Vector3(-400, -250, 0);
		gameObject.SetActive (true);
		transform.position = new Vector2(0,0);
		Debug.Log ("Left Clicked");
	}

	public void button2()
	{
		Debug.Log ("Right Clicked");
	}



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
