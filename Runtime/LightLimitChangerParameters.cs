﻿using System;
using UnityEngine;

namespace io.github.azukimochi
{
    [Serializable]
    public struct LightLimitChangerParameters
    {
        public bool IsDefaultUse;
        public bool IsValueSave;
        public bool OverwriteDefaultLightMinMax;

        [Range(0, 1)]
        public float DefaultLightValue;

        [Range(0, 1)]
        public float DefaultMinLightValue;

        [Range(0, 1)]
        public float DefaultMaxLightValue;

        [Range(0, 10)]
        public float MaxLightValue;

        [Range(0, 10)]
        public float MinLightValue;

        [Obsolete]
        public int TargetShader;

        public TargetShaders TargetShaders;

        public bool AllowColorTempControl;
        public bool AllowSaturationControl;
        public bool AllowMonochromeControl;
        public bool AllowUnlitControl;
        public bool AddResetButton;

        public bool IsSeparateLightControl;

        public bool IsGroupingAdditionalControls;

        public static LightLimitChangerParameters Default => new LightLimitChangerParameters()
        {
            IsDefaultUse = false,
            IsValueSave = false,
            OverwriteDefaultLightMinMax = true,
            DefaultLightValue = 0.5f,
            DefaultMinLightValue = 0.0f,
            DefaultMaxLightValue = 1.0f,
            MaxLightValue = 1.0f,
            MinLightValue = 0.0f,
            //TargetShader = -1, // Everything
            TargetShaders = TargetShaders.Everything,
            AllowColorTempControl = false,
            AllowSaturationControl = false,
            AllowMonochromeControl = false,
            AllowUnlitControl = false,
            AddResetButton = false,
            IsGroupingAdditionalControls = false,
        };
    }
}
