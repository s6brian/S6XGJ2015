/*
 * developer     : brian g. tria
 * creation date : 2015.12.18
 * 
 */

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TutorialScreenManager : MonoBehaviour 
{
	private static TutorialScreenManager m_instance = null;
	public  static TutorialScreenManager Instance {get {return m_instance;}}
	
	private Canvas m_canvas;
	
	protected void Awake ()
	{
		m_instance = this;
		m_canvas = this.GetComponent<Canvas> ();
		m_canvas.enabled = false;
	}
	
	public void Open ()
	{
		m_canvas.enabled = true;
	}
	
	public void Close ()
	{
		m_canvas.enabled = false;
	}
}
