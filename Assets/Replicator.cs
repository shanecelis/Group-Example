using UnityEngine;
using System.Collections;

public class Replicator : MonoBehaviour {

  // Use this for initialization
  void Start () {
    Invoke("Replicate", 0.4f);
  }
  
  // Update is called once per frame
  void Update () {
  
  }

  void Replicate() {
    GameObject go = Instantiate(this.gameObject,
                                transform.position + Vector3.right * 1.2f,
                                Quaternion.identity) as GameObject;
    go.name = this.gameObject.name;
    go.transform.parent = this.transform.root;
  }
}
