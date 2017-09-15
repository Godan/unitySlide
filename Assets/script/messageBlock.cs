using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class messageBlock : MonoBehaviour {

	public GameObject img;
	private BoxCollider2D m_boxCollider2D;


	// Use this for initialization
	void Start () {
		
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
		if (collision2D.gameObject.tag == "Player")
		{
			Vector2 pos = transform.position;
			Vector2 groundCheck = new Vector2(pos.x, pos.y - transform.lossyScale.y);
			Vector2 groundArea = new Vector2(m_boxCollider2D.size.x * transform.lossyScale.y * 0.45f, 0.05f);
			var col2D = Physics2D.OverlapArea(groundCheck + groundArea, groundCheck - groundArea);

			if (col2D) {
				Vector3 point = transform.position;
				point.y = point.y + 4;
				Instantiate (img, point, transform.rotation);
			}
		}
	}
}
