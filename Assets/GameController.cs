using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameController
{
    private static int points;

    public static int Points{
      get{
          return points;
      }
      set{
          points = value;
          if(points < 0){
              points = 0;
          }
      }
    }
}
