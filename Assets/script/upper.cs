using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upper : MonoBehaviour {

	public GameObject slideManager;
	public bool isSub = false;
	private slide slideIdx;
	private BoxCollider2D m_boxCollider2D;

	// Use this for initialization
	void Start () {
		slideIdx = slideManager.GetComponent<slide>();
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	private void Awake()
	{
		m_boxCollider2D = GetComponent<BoxCollider2D>();
	}


	private void OnCollisionEnter2D(Collision2D collision2D)
	{
		Vector2 pos = transform.position;
		Vector2 groundCheck = new Vector2(pos.x, pos.y - transform.lossyScale.y);
		Vector2 groundArea = new Vector2(m_boxCollider2D.size.x * transform.lossyScale.y * 0.45f, 0.05f);
		var col2D = Physics2D.OverlapArea(groundCheck + groundArea, groundCheck - groundArea);

		if (col2D) {
			if (collision2D.gameObject.tag == "Player") {
				if (!isSub) {
					slideIdx.add ();
				} else {
					slideIdx.sub ();
				}
			}
		}
	}
}
