using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoController : MonoBehaviour
{
    AudioSource _do, _re, _mi, _fa, _sol, _la, _si;
    SpriteRenderer _Do, _Re, _Mi, _Fa, _Sol, _La, _Si;
    // Start is called before the first frame update
    void Start()
    {
        _do = GameObject.FindWithTag("do").GetComponent<AudioSource>();
        _re = GameObject.FindWithTag("re").GetComponent<AudioSource>();
        _mi = GameObject.FindWithTag("mi").GetComponent<AudioSource>();
        _fa = GameObject.FindWithTag("fa").GetComponent<AudioSource>();
        _sol = GameObject.FindWithTag("sol").GetComponent<AudioSource>();
        _la = GameObject.FindWithTag("la").GetComponent<AudioSource>();
        _si = GameObject.FindWithTag("si").GetComponent<AudioSource>();

        _Do = GameObject.FindWithTag("do").GetComponent<SpriteRenderer>();
        _Re = GameObject.FindWithTag("re").GetComponent<SpriteRenderer>();
        _Mi = GameObject.FindWithTag("mi").GetComponent<SpriteRenderer>();
        _Fa = GameObject.FindWithTag("fa").GetComponent<SpriteRenderer>();
        _Sol = GameObject.FindWithTag("sol").GetComponent<SpriteRenderer>();
        _La = GameObject.FindWithTag("la").GetComponent<SpriteRenderer>();
        _Si = GameObject.FindWithTag("si").GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) 
        {
            _Do.color = Color.red;
            _do.Play();
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            _Do.color = Color.white;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            _Re.color = Color.blue;
            _re.Play();
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            _Re.color = Color.white;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            _Mi.color = Color.yellow;
            _mi.Play();
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            _Mi.color = Color.white;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            _Fa.color = Color.green;
            _fa.Play();
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            _Fa.color = Color.white;
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            _Sol.color = Color.black;
            _sol.Play();
        }
        if (Input.GetKeyUp(KeyCode.T))
        {
            _Sol.color = Color.white;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            _La.color = Color.cyan;
            _la.Play();
        }
        if (Input.GetKeyUp(KeyCode.Y))
        {
            _La.color = Color.white;
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            _Si.color = Color.grey;
            _si.Play();
        }
        if (Input.GetKeyUp(KeyCode.U))
        {
            _Si.color = Color.white;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
