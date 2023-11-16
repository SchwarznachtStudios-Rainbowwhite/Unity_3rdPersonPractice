using UnityEngine;

public class CameraDirection : MonoBehaviour
{
	private Camera mainCamera;

	private void Awake()
	{
		mainCamera = Camera.main;
	}

	public Vector3 GetCameraForward()
	{
		Vector3 cameraForward = GetPlaneDirection(mainCamera.transform.forward);
		return cameraForward;
	}

	public Vector3 GetCameraSideward()
	{
		Vector3 cameraSidewards = GetPlaneDirection(mainCamera.transform.right);
		return cameraSidewards;
	}

	private Vector3 GetPlaneDirection(Vector3 vector)
	{
		vector.y = 0f;
		vector = vector.normalized;
		return vector;
	}
}