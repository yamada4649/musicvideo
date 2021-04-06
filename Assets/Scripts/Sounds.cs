using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;


public class Sounds : MonoBehaviour
{
    float[] times;

    string[] lyrics; 
    public TextMeshProUGUI title;

    public AudioSource audioSource;
    int counter = 0;
    public int maxVisibleCharacters;
    public TextMeshPro text;
    public PParticleSystem particleSystems;


    void Awake()
    {
    lyrics = new string[13];
    lyrics [0] = "What to do want to do";
    lyrics [1] = "What is the meaning of life";
    lyrics [2] = "理想現実　ワンクリック　光の速度変わっても";
    lyrics [3] = "地球の裏より遠い距離　アダムとイヴにはなれない";
    lyrics [4] = "悲しみの生まれた場所たどって";
    lyrics [5] = "その傷　優しく触れて癒せてたなら";
    lyrics [6] = "あふれる思い　愛は君を照らす光になれる";
    lyrics [7] = "切ないほどに";
    lyrics[8]  = "たとえ描く未来　そこに私がいないとしても";
    lyrics[9]  = "今はそっと抱きしめてあげる";
    lyrics[10] = "運命だって引き寄せて輝き続けたいよ";
    lyrics[11] = "奇跡だって起こせるって信じたい";
    lyrics[12] = "信じたい";

    times = new float[13];
    times [0] = 14.32f;
    times [1] = 25.4f;
    times [2] = 28.8f;
    times [3] = 35.8f;
    times [4] = 43.6f;
    times [5] = 50.34f;
    times [6] = 58.4f;
    times [7] = 68.0f;
    times [8] = 73.4f;
    times [9] = 81.8f;
    times [10] = 88.2f;
    times [11] = 95.3f;
    times [12] = 106.2f;
    }
    // Start is called before the first frame update
    void Start()
    {
        TextMeshProUGUI title = GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(audioSource.isPlaying)
        {
            float now = audioSource.time;
                Debug.Log(now);

             if (counter < lyrics.Length) { if (now >= times [counter]) {
                title.text = lyrics [counter];
                if(times[counter] == 58.4f)
                {
                  particleSystems =   particleSystems.GetComponent<PParticleSystem>();
                  particleSystems.ParticleStart();
                }

                counter++;
            }
             }
        }
        
    }
}
