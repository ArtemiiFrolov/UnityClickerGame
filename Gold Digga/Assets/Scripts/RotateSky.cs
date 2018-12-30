using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSky : MonoBehaviour {

    public float speed = 1.1f;

	void Update () {
        RenderSettings.skybox.SetFloat("_Rotation", speed*Time.time);
	}
}
