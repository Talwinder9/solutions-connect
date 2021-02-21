using System;
using System.Collections.Generic;
using System.Text;

namespace TesterApp
{
  /*
   Add Methods to CharInput:
    - Add (char c){Adds c to current value}
    - GetValue(){returns current value}
   */
  public class CharInput
  {
        public String result = String.Empty;
        public virtual void Add (char c)
    {
            result += c;
    }

    public string GetValue()
    {
      return result.ToString();
    }
  }
}
