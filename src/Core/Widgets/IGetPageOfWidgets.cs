﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Widgets
{
    public interface IGetPageOfWidgets
    {
        Page<WidgetSummary> GetPageOfWidgets(int number = 1);
    }
}