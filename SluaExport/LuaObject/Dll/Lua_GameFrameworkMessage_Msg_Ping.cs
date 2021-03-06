﻿using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_GameFrameworkMessage_Msg_Ping : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			GameFrameworkMessage.Msg_Ping o;
			o=new GameFrameworkMessage.Msg_Ping();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_send_ping_time(IntPtr l) {
		try {
			GameFrameworkMessage.Msg_Ping self=(GameFrameworkMessage.Msg_Ping)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.send_ping_time);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_send_ping_time(IntPtr l) {
		try {
			GameFrameworkMessage.Msg_Ping self=(GameFrameworkMessage.Msg_Ping)checkSelf(l);
			System.Int64 v;
			checkType(l,2,out v);
			self.send_ping_time=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"GameFrameworkMessage.Msg_Ping");
		addMember(l,"send_ping_time",get_send_ping_time,set_send_ping_time,true);
		createTypeMetatable(l,constructor, typeof(GameFrameworkMessage.Msg_Ping));
	}
}
