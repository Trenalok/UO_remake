using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Scripts.Items;
public class button : MonoBehaviour, IPointerClickHandler {

	public GameObject[] but;
	private bool rightClick=false;

	public void OnPointerClick(PointerEventData eventData)
	{
		if (eventData.button == PointerEventData.InputButton.Left)
		{
			if (!rightClick)
				button1 ();
			else
				button11 ();
		}
			//Debug.Log ("Left click");
		else if (eventData.button == PointerEventData.InputButton.Right)
		{
			rightClick = !rightClick;
			button2 ();
		}
			//Debug.Log ("Right Click");
	}


	public void button1()
	{
		
		//GameObject but = GameObject.Find ("Button(1)");
		//bit.image.sprite = butt;
		GameObject.Find("EntityManager").GetComponent<EntityManager>().CreateItem(EnumClothingItems.PlateBreast, EnumResourceType.LavaRock);
	}

	public void button11()
	{
		gameObject.SetActive (false);
	}

	public void button2()
	{
		foreach (GameObject butt in but)
		{
			bool active = butt.activeSelf;
			if (active)
			{
				butt.SetActive (false);
			}
			else
				butt.SetActive (true);
		}
	}





	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
