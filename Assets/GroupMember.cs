﻿using UnityEngine;
using System.Collections;

public class GroupMember : MonoBehaviour {
  public string groupName = "Group";

  // Use this for initialization
  void Start () {
    Group group = Group.GetGroup(groupName);
    group.Register(this);
  }

  void OnDestroy() {
    Group.Deregister(this);
  }
}
