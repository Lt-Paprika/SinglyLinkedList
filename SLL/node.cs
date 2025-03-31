using System;

namespace Assignment_3_skeleton
{
  public class Node
  {
    public object Data { get; set; }
    public Node Next { get; set; }

    public Node(Object data)
    {
      Data = data;
      Next = null;
    }
  }
}
