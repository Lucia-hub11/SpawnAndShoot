using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    ParticleSystem _ps;
    // Start is called before the first frame update
    void Start()
    {
        _ps = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ShouldPlay())
            Play();

        SetAmount(Time.time);
        SetNoise(Time.time);
        SetTrails(Time.time);
    }

    private void SetTrails(float time)
    {
        var trails = _ps.trails;
        trails.lifetime = time / 10;
    }

    private void SetNoise(float time)
    {
        var noise = _ps.noise;
        noise.strength = time / 5;
    }

    void SetAmount(float n)
    {
        var emitor = _ps.emission;
        emitor.rateOverTime = n;
    }

    private bool ShouldPlay()
    {
        return Input.GetKeyDown(KeyCode.Space);
    }

    private void Play()
    {
        _ps.Play();
    }

}
