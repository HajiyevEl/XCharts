﻿
/************************************************/
/*                                              */
/*     Copyright (c) 2018 - 2021 monitor1394    */
/*     https://github.com/monitor1394           */
/*                                              */
/************************************************/

using UnityEngine;

namespace XCharts
{
    [AddComponentMenu("XCharts/LineChart", 13)]
    [ExecuteInEditMode]
    [RequireComponent(typeof(RectTransform))]
    [DisallowMultipleComponent]
    public class LineChart : BaseChart
    {

#if UNITY_EDITOR
        protected override void Reset()
        {
            base.Reset();
            AddChartComponentWhenNoExist<GridCoord>();
            AddChartComponentWhenNoExist<XAxis>();
            AddChartComponentWhenNoExist<YAxis>();

            var tooltip = GetChartComponent<Tooltip>();
            tooltip.type = Tooltip.Type.Line;
            tooltip.trigger = Tooltip.Trigger.Axis;

            RemoveData();
            Line.AddDefaultSerie(this, GenerateDefaultSerieName());
            for (int i = 0; i < 5; i++)
            {
                AddXAxisData("x" + (i + 1));
            }
        }
#endif
    }
}