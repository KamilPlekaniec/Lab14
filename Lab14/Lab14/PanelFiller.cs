﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Lab14
{
    public class PanelFiller : IPanelFiller
    {
        public PanelFiller(IControlGenerator controlGenerator, IDataProvider dataProvider)
        {
            ControlGenerator = controlGenerator;
            _dataProvider = dataProvider;
        }
        public IControlGenerator ControlGenerator { get; set; }
        private IDataProvider _dataProvider { get; set; }
        public void Fill(Panel panel)
        {
            for (int i = 0; i < 10; i++)
            {
                panel.Children.Add(ControlGenerator.Generate(_dataProvider.GetData()));
            }
        }
    }
}
