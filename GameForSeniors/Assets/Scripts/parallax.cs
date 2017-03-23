using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax : MonoBehaviour {

    public Transform[] backgrounds;
    private float[] scales;
    public float smoothing = 1f;

    private Transform cam;
    private Vector3 prevCam;

    void Awake()
    {
        cam = Camera.main.transform;
    }


	// Use this for initialization
	void Start () {

        prevCam = cam.position;
        scales = new float[backgrounds.Length];
        for (int i = 0; i < backgrounds.Length; i++)
        {
            scales[i] = backgrounds[i].position.z * -1;
        }
	}
	
	// Update is called once per frame
	void Update () {

        for (int i = 0; i < backgrounds.Length; i++)
        {
            float parallaxPos = (prevCam.x - cam.position.x) * scales[i];
            float backTargetPosX = backgrounds[i].position.x + parallaxPos;
            Vector3 backtargetPos = new Vector3(backTargetPosX, backgrounds[i].position.y, backgrounds[i].position.z);

            backgrounds[i].position = Vector3.Lerp(backgrounds[i].position, backtargetPos, smoothing * Time.deltaTime);
        }

        prevCam = cam.position;
	}
}
