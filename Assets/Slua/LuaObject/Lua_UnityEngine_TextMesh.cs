﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_TextMesh : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.TextMesh o;
		if(matchType(l,1)){
			o=new UnityEngine.TextMesh();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_text(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		pushValue(l,o.text);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_text(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.text=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_font(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		pushValue(l,o.font);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_font(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		UnityEngine.Font v;
		checkType(l,2,out v);
		o.font=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fontSize(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		pushValue(l,o.fontSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fontSize(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.fontSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fontStyle(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		pushValue(l,o.fontStyle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fontStyle(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		UnityEngine.FontStyle v;
		checkEnum(l,2,out v);
		o.fontStyle=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_offsetZ(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		pushValue(l,o.offsetZ);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_offsetZ(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.offsetZ=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alignment(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		pushValue(l,o.alignment);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_alignment(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		UnityEngine.TextAlignment v;
		checkEnum(l,2,out v);
		o.alignment=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_anchor(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		pushValue(l,o.anchor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_anchor(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		UnityEngine.TextAnchor v;
		checkEnum(l,2,out v);
		o.anchor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_characterSize(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		pushValue(l,o.characterSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_characterSize(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.characterSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lineSpacing(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		pushValue(l,o.lineSpacing);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lineSpacing(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.lineSpacing=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tabSize(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		pushValue(l,o.tabSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tabSize(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.tabSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_richText(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		pushValue(l,o.richText);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_richText(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.richText=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_color(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		pushValue(l,o.color);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_color(IntPtr l) {
		UnityEngine.TextMesh o = (UnityEngine.TextMesh)checkSelf(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.color=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.TextMesh");
		addMember(l,"text",get_text,set_text);
		addMember(l,"font",get_font,set_font);
		addMember(l,"fontSize",get_fontSize,set_fontSize);
		addMember(l,"fontStyle",get_fontStyle,set_fontStyle);
		addMember(l,"offsetZ",get_offsetZ,set_offsetZ);
		addMember(l,"alignment",get_alignment,set_alignment);
		addMember(l,"anchor",get_anchor,set_anchor);
		addMember(l,"characterSize",get_characterSize,set_characterSize);
		addMember(l,"lineSpacing",get_lineSpacing,set_lineSpacing);
		addMember(l,"tabSize",get_tabSize,set_tabSize);
		addMember(l,"richText",get_richText,set_richText);
		addMember(l,"color",get_color,set_color);
		createTypeMetatable(l,constructor, typeof(UnityEngine.TextMesh),typeof(UnityEngine.Component));
	}
}
