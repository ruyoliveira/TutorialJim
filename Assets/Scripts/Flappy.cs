using UnityEngine;
using System.Collections;

public class Flappy : MonoBehaviour {
    public Rigidbody2D _rigid;
    public float velocidade = 3.0f;
    // verifica colisao
    void OnCollisionEnter2D(Collision2D c)
    {
        // reinicia o jogo
        Application.LoadLevel(0);
    }

	// Use this for initialization
	void Start () 
    {
        _rigid = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () 
    {
	
        if (Input.GetMouseButtonDown(0))
        {
            _rigid.velocity = Vector2.up * velocidade;
        }
	}
}
