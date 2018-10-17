using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour
{
	/// Transform of the camera to shake. Grabs the gameObject's transform
// if null.
public Transform camTransform;

// How long the object should shake for.
public float shakeDuration = 0f;

// Amplitude of the shake. A larger value shakes the camera harder.
public float shakeAmount = 0.7f;
public float decreaseFactor = 1.0f;

public bool shaketrue= false;

Vector3 originalPos;

void Awake()
{
	if (camTransform == null)
	{
		camTransform = GetComponent(typeof(Transform)) as Transform;
	}
}

void OnEnable()
{
	originalPos = camTransform.localPosition;
}

void Update()
{
	if (shaketrue) 
	{
		if (shakeDuration > 0) {
			camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;

			shakeDuration -= Time.deltaTime * decreaseFactor;
		} else {
			shakeDuration = 1f;
			camTransform.localPosition = originalPos;
			shaketrue = false;
		}
	}
}

public void shakeCamera()
{
	shaketrue = true;
}
}