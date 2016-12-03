using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MonsterController : MonoBehaviour {

	// Use this for initialization

	public SamController samController;
	private bool monsterFlag = false;
	private bool samCaughtFlag = false;

	void Start () {
		//MeshRenderer m = this.GetComponent<MeshRenderer>();
		//m.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		//CatchSam ();

		if (!monsterFlag && samController.getSpeed() >= 40) {
			MeshRenderer m = this.GetComponent<MeshRenderer>();
			m.enabled = true;
			monsterFlag = true;
		}
		if (monsterFlag && !samCaughtFlag && samController.getSpeed () <= 30) {
			CatchSam ();
			samCaughtFlag = true;
		} 
		if (samCaughtFlag)
			CatchSam ();
					
	}

	void CatchSam() {
		Vector3 newPosition = samController.getSamPosition ();
		this.transform.position = newPosition;
	}

	public bool isSamCaught () {
		return samCaughtFlag;
	}

}
