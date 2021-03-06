﻿namespace Model
{
	// 分发数值监听
	[Event((int)EventIdType.NumbericChange)]
	public class NumericChangeEvent_NotifyWatcher: AEvent<NumericType, long, int>
	{
		public override void Run(NumericType numericType, long id, int value)
		{
			Game.Scene.GetComponent<NumericWatcherComponent>().Run(numericType, id, value);
		}
	}
}
