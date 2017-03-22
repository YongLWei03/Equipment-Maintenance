using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace EquipmentMaintenance
{
    class RealChart
    {
        //public DispatcherTimer Timer { get; set; }
        //public bool IsDataInjectionRunning { get; set; }
        //public Random R { get; set; }

        //private void RunDataOnClick(object sender, RoutedEventArgs e)
        //{
        //    if (IsDataInjectionRunning)
        //    {
        //        Timer.Stop();
        //        IsDataInjectionRunning = false;
        //    }
        //    else
        //    {
        //        Timer.Start();
        //        IsDataInjectionRunning = true;
        //    }
        //}

        //private void TimerOnTick(object sender, object eventArgs)
        //{
        //    var now = DateTime.Now;

        //    ChartValues.Add(new MeasureModel
        //    {
        //        DateTime = now,
        //        Value = R.Next(0, 10)
        //    });

        //    SetAxisLimits(now);

        //    //lets only use the last 30 values
        //    if (ChartValues.Count > 30) ChartValues.RemoveAt(0);
        //}

        //private void SetAxisLimits(DateTime now)
        //{
        //    AxisMax = now.Ticks + TimeSpan.FromSeconds(1).Ticks; // lets force the axis to be 100ms ahead
        //    AxisMin = now.Ticks - TimeSpan.FromSeconds(8).Ticks; //we only care about the last 8 seconds
        //}
    }
}
