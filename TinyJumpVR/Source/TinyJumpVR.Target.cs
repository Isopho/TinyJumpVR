// Copyright 2019-2021 Isophonic Bottle. All Rights Reserved

using UnrealBuildTool;
using System.Collections.Generic;

public class TinyJumpVRTarget : TargetRules
{
	public TinyJumpVRTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "TinyJumpVR" } );
	}
}
