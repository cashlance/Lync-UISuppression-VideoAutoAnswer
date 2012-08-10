﻿/* Copyright (C) 2012 Modality Systems - All Rights Reserved
 * You may use, distribute and modify this code under the
 * terms of the Microsoft Public License, a copy of which 
 * can be seen at: http://www.microsoft.com/en-us/openness/licenses.aspx
 * 
 * http://www.LyncAutoAnswer.com
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LyncUISupressionWrapper
{
   public class StringValueInformationEventArgs : EventArgs
    {
        public string Value{ get; private set; }

        private StringValueInformationEventArgs() { }
        internal StringValueInformationEventArgs(string pValue)
        {
            Value = pValue;
        }
    }
}
