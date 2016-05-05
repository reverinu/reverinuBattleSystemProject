using UnityEngine;
using System.Collections;

public class BattleManager : MonoBehaviour {

    public CharaInfo charaInfo;

	// Use this for initialization
	void Start () {
        charaInfo = charaInfo.GetComponent<CharaInfo>();
	}
	
	// Update is called once per frame
	void Update () {
        charaInfo.atk = 3;
	}


}
