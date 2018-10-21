using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class UDTManager : MonoBehaviour, IUserDefinedTargetEventHandler {

	UserDefinedTargetBuildingBehaviour udt_targetBuildingBehaviour;
	
	ObjectTracker objectTracker;
	DataSet dataSet;

	ImageTargetBuilder.FrameQuality udt_FrameQuality;

	public ImageTargetBehaviour targetBehaviour;

	int targetCounter;

	// Use this for initialization
	void Start () {
		
		udt_targetBuildingBehaviour = GetComponent<UserDefinedTargetBuildingBehaviour>();	
		if (udt_targetBuildingBehaviour)
		{
			udt_targetBuildingBehaviour.RegisterEventHandler(this);
		}	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnFrameQualityChanged(ImageTargetBuilder.FrameQuality frameQuality)
	{
		udt_FrameQuality = frameQuality;
	}

	public void OnInitialized()
	{
		objectTracker = TrackerManager.Instance.GetTracker<ObjectTracker>();
		if(objectTracker!=null)
		{
			dataSet = objectTracker.CreateDataSet();
			objectTracker.ActivateDataSet(dataSet);
		}
	}

	public void OnNewTrackableSource(TrackableSource trackableSource)
	{
		targetCounter++;
		objectTracker.DeactivateDataSet(dataSet);

		dataSet.CreateTrackable(trackableSource, targetBehaviour.gameObject);

		objectTracker.ActivateDataSet(dataSet);

		udt_targetBuildingBehaviour.StartScanning();
	}
	
	public void Buildtarget()
	{
		if(udt_FrameQuality == ImageTargetBuilder.FrameQuality.FRAME_QUALITY_HIGH)
		{
			udt_targetBuildingBehaviour.BuildNewTarget(targetCounter.ToString(),targetBehaviour.GetSize().x);
		}
	}
	
	public void PlaceCharacter () {
		transform.localPosition = Vector3.zero;
	}

}
