﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForSeconds : MonoBehaviour {

IEnumerator Wait()
    {
        yield return new WaitForSecondsRealtime(10f);
    }
}
