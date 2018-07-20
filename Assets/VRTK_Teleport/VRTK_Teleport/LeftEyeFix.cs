using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftEyeFix : MonoBehaviour {

	Camera _centerEyeCamera;

	void Awake()
	{
		_centerEyeCamera = this.GetComponent<Camera>();
		_centerEyeCamera.stereoTargetEye = StereoTargetEyeMask.Left;
	}

	void fixEyeCam()
	{
		_centerEyeCamera = this.GetComponent<Camera>();
		_centerEyeCamera.stereoTargetEye = StereoTargetEyeMask.Left;
	}

	void Start () {
		_centerEyeCamera.stereoTargetEye = StereoTargetEyeMask.Left;
		Invoke ("fixEyeCam", 1.0f);
	}	

}
