using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class BaseHotdogSO : Hotdog
    {
        private HotdogConfig config;

        public BaseHotdogSO(HotdogConfig config)
            : base(config.hotdogName)
        {
            this.config = config;
        }

        public override int GetCost() => config.cost;
        public override int GetWeight() => config.weight;
    }

