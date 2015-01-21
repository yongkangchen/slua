﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_PlayMode : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.PlayMode o = (UnityEngine.PlayMode)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.PlayMode");
		addMember(l,0,"StopSameLayer");
		addMember(l,4,"StopAll");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
