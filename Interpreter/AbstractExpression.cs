﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public interface AbstractExpression
    {
        void Evaluate(Context context);
    }

}
