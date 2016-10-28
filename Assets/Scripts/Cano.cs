using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Cano : MonoBehaviour {
    public float velocidade = 2.0f;
    public float maxY;
    public float minY;
    public float posX;
    public float intervalo;
    public float cronometro;
    public int pontuacao;
    public Text textoPontuacao;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	    
        transform.Translate(Vector2.left * velocidade * Time.deltaTime);
        cronometro = cronometro + Time.deltaTime;
        if (cronometro > intervalo)
        {
            pontuacao++;
            textoPontuacao.text = pontuacao.ToString();
            Vector2 novaPosicao;
            novaPosicao.x = posX;
            novaPosicao.y = Random.Range(minY,maxY);
            transform.position = novaPosicao;
            cronometro = 0.0f;
        }
    }
}
