using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour
{

		public string Scene;
		void OnMouseDown ()
		{
				Application.LoadLevel (Scene);
		}

}
