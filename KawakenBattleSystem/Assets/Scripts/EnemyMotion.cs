using UnityEngine;
using System.Collections;

public class EnemyMotion : MonoBehaviour {

    private float charaSizeX;
    private float charaSizeY;

    void Start()
    {
        charaSizeX = this.GetComponent<RectTransform>().sizeDelta.x;
    }

	
    void FixedUpdate()
    {
        charaSizeY = Mathf.PingPong(Time.time * 2, 1) * 5 + this.GetComponent<RectTransform>().sizeDelta.x;

        this.GetComponent<RectTransform>().sizeDelta = new Vector2(charaSizeX, charaSizeY);
    }
}
