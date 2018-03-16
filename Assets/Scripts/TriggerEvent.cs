using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour {
	public UnityEvent TriggerEnter;
	public UnityEvent TriggerExit;
	public UnityEvent TriggerStay;

	private void OnTriggerEnter() {
		if (TriggerEnter != null) {
				TriggerEnter.Invoke();
		}
	}

	private void OnTriggerExit() {
		if (TriggerExit != null) {
			TriggerExit.Invoke();
		}
	}

	private void OnTriggerStay() {
		if (TriggerStay != null) {
			TriggerStay.Invoke();
		}
	}
}
