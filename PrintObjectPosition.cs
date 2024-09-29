using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintObjectPosition : MonoBehaviour {
  void Start() {
    foreach (Transform child in transform) {
      Debug.Log($"Child: {child.name}, Position: {child.position}");
    }
  }
}