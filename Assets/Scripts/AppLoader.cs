/*
 * developer     : brian g. tria
 * creation date : 2015.11.25
 * 
 */

using UnityEngine;
using System.Collections;

public class AppLoader : MonoBehaviour 
{
	protected void Awake ()
	{
		StartCoroutine ("LoadApp");
	}
	
	private IEnumerator LoadApp ()
	{
		#region LOAD ALL CANVAS
		GameObject[] canvasObjectArray = Resources.LoadAll<GameObject> ("Prefabs/Canvas");
		
		for (int idx = canvasObjectArray.Length-1; idx >= 0; --idx)
		{
//			canvasObjectArray.
		}
		#endregion
	}
}
