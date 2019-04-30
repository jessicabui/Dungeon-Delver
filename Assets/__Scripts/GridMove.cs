using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMove : MonoBehaviour {

      private IFacingMover mover;

      void Awake()
    {
        mover = GetComponent<IFacingMIFacingMover>() ;

    }


}