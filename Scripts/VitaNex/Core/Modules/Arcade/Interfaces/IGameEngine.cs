#region Header
//   Vorspire    _,-'/-'/  IGameEngine.cs
//   .      __,-; ,'( '/
//    \.    `-.__`-._`:_,-._       _ , . ``
//     `:-._,------' ` _,`--` -: `_ , ` ,' :
//        `---..__,,--'  (C) 2016  ` -'. -'
//        #  Vita-Nex [http://core.vita-nex.com]  #
//  {o)xxx|===============-   #   -===============|xxx(o}
//        #        The MIT License (MIT)          #
#endregion

#region References
using System;

using Server;
#endregion

namespace VitaNex.Modules.Games
{
	public interface IGameEngine : IDisposable
	{
		Type UIType { get; }

		bool IsDisposed { get; }
		bool IsDisposing { get; }

		Mobile User { get; }

		IGame Game { get; }
		IGameUI UI { get; }

		ArcadeProfile Profile { get; }

		GameStatistics Statistics { get; }

		double Points { get; }

		bool Validate();

		bool Open();
		void Close();
		void Reset();

		void LogStatistics();

		void Log(string context, double value, bool offset);
		void LogIncrease(string context, double value);
		void LogDecrease(string context, double value);

		void OffsetPoints(double value, bool log);
		void IncreasePoints(double value, bool log);
		void DecreasePoints(double value, bool log);

		void Serialize(GenericWriter writer);
		void Deserialize(GenericReader reader);
	}
}