using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
public class ARTouch : MonoBehaviour
{
    public GameObject carroVerde;
    public GameObject carroVermelho;
    public GameObject carroAzul;
    public GameObject carroAmarelo;

    // audios
    public AudioClip CarsclipVerde;

    public AudioClip CarsclipNotVerde;

    AudioSource audio;
        void Start()
    {
        audio = GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Pressed primary button.");

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100))
            {
                Debug.Log("hit");
                Debug.Log(hit.transform.name + " : " + hit.transform.tag);

                if (hit.transform.tag == "carro_verde")
                {
                    Debug.Log("Carro Verde");
                    Vector3 pos = hit.point;
                    pos.z += 0.25f;
                    pos.y += 0.25f;
                    Instantiate(carroVerde, pos, transform.rotation);
                    audio.PlayOneShot(CarsclipVerde, 1);

                }

                if (hit.transform.tag == "carro_vermelho")
                {
                    Debug.Log("Carro Vermelho");
                    Vector3 pos = hit.point;
                    pos.z += 0.25f;
                    pos.y += 0.25f;
                    Instantiate(carroVermelho, pos, transform.rotation);
                    audio.PlayOneShot(CarsclipNotVerde, 1);

                }

                if (hit.transform.tag == "carro_azul")
                {
                    Debug.Log("Carro Azul");
                    Vector3 pos = hit.point;
                    pos.z += 0.15f;
                    pos.y += 0.25f;
                    Instantiate(carroAzul, pos, transform.rotation);
                    audio.PlayOneShot(CarsclipNotVerde, 1);

                }

                if (hit.transform.tag == "carro_amarelo")
                {
                    Debug.Log("Carro Amarelo");
                    Vector3 pos = hit.point;
                    pos.z += 0.15f;
                    pos.y += 0.25f;
                    Instantiate(carroAmarelo, pos, transform.rotation);
                    audio.PlayOneShot(CarsclipNotVerde, 1);

                }

                if (hit.transform.tag == "VerdeInfo")
                {
                    Destroy(hit.transform.gameObject);
                }

                if (hit.transform.tag == "VermelhoInfo")
                {
                    Destroy(hit.transform.gameObject);
                }

                if (hit.transform.tag == "AzulInfo")
                {
                    Destroy(hit.transform.gameObject);
                }
                
                 if (hit.transform.tag == "AmareloInfo")
                {
                    Destroy(hit.transform.gameObject);
                }

            }
        }
    }
}