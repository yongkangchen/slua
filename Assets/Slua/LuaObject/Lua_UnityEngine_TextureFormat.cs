﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_TextureFormat : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.TextureFormat o = (UnityEngine.TextureFormat)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.TextureFormat");
		addMember(l,1,"Alpha8");
		addMember(l,2,"ARGB4444");
		addMember(l,3,"RGB24");
		addMember(l,4,"RGBA32");
		addMember(l,5,"ARGB32");
		addMember(l,7,"RGB565");
		addMember(l,10,"DXT1");
		addMember(l,12,"DXT5");
		addMember(l,13,"RGBA4444");
		addMember(l,14,"BGRA32");
		addMember(l,30,"PVRTC_RGB2");
		addMember(l,31,"PVRTC_RGBA2");
		addMember(l,32,"PVRTC_RGB4");
		addMember(l,33,"PVRTC_RGBA4");
		addMember(l,34,"ETC_RGB4");
		addMember(l,35,"ATC_RGB4");
		addMember(l,36,"ATC_RGBA8");
		addMember(l,38,"ATF_RGB_DXT1");
		addMember(l,39,"ATF_RGBA_JPG");
		addMember(l,40,"ATF_RGB_JPG");
		addMember(l,41,"EAC_R");
		addMember(l,42,"EAC_R_SIGNED");
		addMember(l,43,"EAC_RG");
		addMember(l,44,"EAC_RG_SIGNED");
		addMember(l,45,"ETC2_RGB");
		addMember(l,46,"ETC2_RGBA1");
		addMember(l,47,"ETC2_RGBA8");
		addMember(l,48,"ASTC_RGB_4x4");
		addMember(l,49,"ASTC_RGB_5x5");
		addMember(l,50,"ASTC_RGB_6x6");
		addMember(l,51,"ASTC_RGB_8x8");
		addMember(l,52,"ASTC_RGB_10x10");
		addMember(l,53,"ASTC_RGB_12x12");
		addMember(l,54,"ASTC_RGBA_4x4");
		addMember(l,55,"ASTC_RGBA_5x5");
		addMember(l,56,"ASTC_RGBA_6x6");
		addMember(l,57,"ASTC_RGBA_8x8");
		addMember(l,58,"ASTC_RGBA_10x10");
		addMember(l,59,"ASTC_RGBA_12x12");
		addMember(l,30,"PVRTC_2BPP_RGB");
		addMember(l,31,"PVRTC_2BPP_RGBA");
		addMember(l,32,"PVRTC_4BPP_RGB");
		addMember(l,33,"PVRTC_4BPP_RGBA");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
