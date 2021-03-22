using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Receives screen resizing instructions from index.html

public class ResizeDetector : MonoBehaviour
{
	private int Width = 0;
	private int Heigth = 0;
	public Text TextField = null;
	
	public void SetWidth(int width)
	{
		Width = width;
	}
	
	public void SetHeigth(int heigth)
	{
		Heigth = heigth;
	}
	
	public void OnResize()
	{
		TextField.text = Width + "x" + Heigth;
		Screen.SetResolution(Width, Heigth, Screen.fullScreen);
	}
}
